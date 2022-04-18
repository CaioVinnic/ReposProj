using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ApiViaCep.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string urlMain = ConfigurationManager.AppSettings["urlMain"].ToString();
            string url;

            Console.WriteLine("Digite a UF: ");
            var uf = Console.ReadLine();

            if (string.IsNullOrEmpty(uf))
            {
                Console.WriteLine("UF Inválida");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Buscando os Dados da Tabela SQL - Inicio - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                var lstCepGeo = GetData(uf);
                Console.WriteLine("Buscando os Dados da Tabela SQL - Fim - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                Console.WriteLine("Buscando os Dados na API - Inicio - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                for (int i = 0; i <= lstCepGeo.Count - 1; i++)
                {
                    if (lstCepGeo[i].LATITUDE.Trim().Equals("") ||
                        lstCepGeo[i].LATITUDE.Trim().Equals("-") ||
                        lstCepGeo[i].LATITUDE.Trim().Equals("0"))
                    {
                        lstCepGeo[i].URL = "";
                        lstCepGeo[i].VALIDACAO = "False";
                    }
                    else
                    {
                        url = urlMain + "/" + lstCepGeo[i].CEP + "/json/";

                        lstCepGeo[i].URL = url;
                        lstCepGeo[i].VALIDACAO = Api(url);
                    }

                    c++;
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("{0}", c);
                }
                Console.WriteLine();
                Console.WriteLine("Buscando os Dados na API - Fim - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                Console.WriteLine("Atualizado os Dados na Tabela SQL - Inicio - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                UpdateData(lstCepGeo);
                Console.WriteLine("Atualizado os Dados na Tabela SQL - Fim - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        static string Api(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest req = (HttpWebRequest)WebRequest.CreateDefault(uri);

            String username = "morimoto";
            String password = "pitubas";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            req.Headers.Add("Authorization", "Basic " + encoded);
            req.Accept = "application/json";
            req.UserAgent = "json";
            req.Method = "GET";

            req.Timeout = -1;
            //req.KeepAlive = true;

            try
            {
                HttpWebResponse response = req.GetResponse() as HttpWebResponse;
                Stream responsedata = response.GetResponseStream();
                StreamReader responsereader = new StreamReader(responsedata);
                string retorno = responsereader.ReadToEnd();

                var x = JsonConvert.DeserializeObject<dynamic>(retorno);

                //return x.Validadao;
                return "True";
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return "False";
            }
        }

        static List<cep_geo_csv> GetData(string uf)
        {
            string query =
                "select CEP, LATITUDE, LONGITUDE, UF, CO_CIDADE, NM_CIDADE " +
                "from cep_geo_csv_230518 " +
                "where uf = @uf " +
                "and (isnull(validacao, 'False') = 'False' or validacao = '') ";

            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL"].ConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;    
            cmd.Parameters.AddWithValue("@uf", uf);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt.ToList<cep_geo_csv>();
        }

        static void UpdateData(List<cep_geo_csv> parametros)
        {
            int c = 0;
            string command =
                "update cep_geo_csv_230518 " +
                "set validacao = @Validacao, " +
                "url = @url " + 
                "where cep = @cep " +
                "and latitude = @latitude " +
                "and longitude = @longitude ";

            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;

            for (int i = 0; i <= parametros.Count - 1; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Validacao", parametros[i].VALIDACAO);
                cmd.Parameters.AddWithValue("@url", parametros[i].URL);
                cmd.Parameters.AddWithValue("@cep", parametros[i].CEP);
                cmd.Parameters.AddWithValue("@latitude", parametros[i].LATITUDE);
                cmd.Parameters.AddWithValue("@longitude", parametros[i].LONGITUDE);
                cmd.ExecuteNonQuery();

                c++;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("{0}", c);
            }
        }
    }

    class cep_geo_csv
    {
        public string CEP { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string UF { get; set; }
        public string CO_CIDADE { get; set; }
        public string NM_CIDADE { get; set; }        
        public string VALIDACAO { get; set; }
        public string URL { get; set; }
    }


}
