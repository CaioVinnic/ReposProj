using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace ValidaLatLon_Ceps000
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string urlMain = ConfigurationManager.AppSettings["urlMain"].ToString();
            string url;

            Console.WriteLine("Validação Latitude Longitude - Ceps final 000");
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
                        if (uf != "DF")
                            url = urlMain + "/" + lstCepGeo[i].SG_UF_MUNICIPIO_RESIDENCIA + "/" + lstCepGeo[i].CO_MUNICIPIO_RESIDENCIA + "/" + lstCepGeo[i].LATITUDE.Replace(",", ".") + "/" + lstCepGeo[i].LONGITUDE.Replace(",", ".");
                        else
                            url = urlMain + "/" + lstCepGeo[i].SG_UF_MUNICIPIO_RESIDENCIA + "/5300108/" + lstCepGeo[i].LATITUDE.Replace(",", ".") + "/" + lstCepGeo[i].LONGITUDE.Replace(",", ".");

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
                UpdateData(uf, lstCepGeo);
                Console.WriteLine();
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
            req.Method = "POST";

            req.Timeout = -1;

            try { 

                HttpWebResponse response = req.GetResponse() as HttpWebResponse;
                Stream responsedata = response.GetResponseStream();
                StreamReader responsereader = new StreamReader(responsedata);
                string retorno = responsereader.ReadToEnd();

                var x = JsonConvert.DeserializeObject<dynamic>(retorno);
                return (string)x.Validacao;

            }
            catch
            {
                return "";
            }
        }

        static List<Cep_000> GetData(string uf)
        {
            string query =
                "select TX_END_BAIRRO, NO_MUNICIPIO_RESIDENCIA, CO_MUNICIPIO_RESIDENCI" +
                "A, SG_UF_MUNICIPIO_RESIDENCIA, CEP, LATITUDE, LONGITUDE " +
                "from CEPS_000_" + uf + " " +
                "where (isnull(validacao, 'False') = 'False' or validacao = '') and CO_MUNICIPIO_RESIDENCIA is not null";

            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL"].ConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@uf", uf);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt.ToList<Cep_000>();
        }   

        static void UpdateData(string uf, List<Cep_000> parametros)
        {
            int c = 0;
            string command =
                "update CEPS_000_" + uf + " " +
                "set validacao = @Validacao, " +
                "url = @url " +
                "where sg_uf_municipio_residencia = @sg_uf_municipio_residencia " +
                "and rtrim(ltrim(co_municipio_residencia)) = @co_municipio_residencia " +
                "and cep = @tx_end_cep " +
                "and tx_end_bairro = @tx_end_bairro ";


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
                cmd.Parameters.AddWithValue("@sg_uf_municipio_residencia", parametros[i].SG_UF_MUNICIPIO_RESIDENCIA);
                cmd.Parameters.AddWithValue("@co_municipio_residencia", parametros[i].CO_MUNICIPIO_RESIDENCIA);
                cmd.Parameters.AddWithValue("@tx_end_bairro", parametros[i].TX_END_BAIRRO);
                cmd.Parameters.AddWithValue("@tx_end_cep", parametros[i].CEP);
                cmd.ExecuteNonQuery();

                c++;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("{0}", c);
            }
        }
    }

    class Cep_000
    {
        public string TX_END_BAIRRO { get; set; }
        public string NO_MUNICIPIO_RESIDENCIA { get; set; }
        public string CO_MUNICIPIO_RESIDENCIA { get; set; }
        public string SG_UF_MUNICIPIO_RESIDENCIA { get; set; }
        public string CEP { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string VALIDACAO { get; set; }
        public string URL { get; set; }
    }

}
