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

namespace AtualizaLatLon_Google_Cep
{
    class Program
    {

        static void Main(string[] args)
        {
            //Api("https://maps.googleapis.com/maps/api/geocode/json?address=69900285&key=AIzaSyDydfOwFD9EvpX0ZeubKKMGskSkN6zi0mk");

            int c = 0;
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

                Console.WriteLine("Buscando os Dados na API Google - Inicio - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                for (int i = 0; i <= lstCepGeo.Count - 1; i++)
                {
                    //url = string.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyDydfOwFD9EvpX0ZeubKKMGskSkN6zi0mk", lstCepGeo[i].CEP);
                    url = string.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyAWA9QJs1IR27nr5aZw1Zg7Grqttc3yGIg", lstCepGeo[i].CEP);                    
                    var resultadoApi = Api(url);

                    if (resultadoApi != null)
                    {
                        lstCepGeo[i].LATITUDE = resultadoApi.LATITUDE;
                        lstCepGeo[i].LONGITUDE = resultadoApi.LONGITUDE;
                        lstCepGeo[i].VALIDACAO = resultadoApi.VALIDACAO;
                    }

                    c++;
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("{0}", c);
                }
                Console.WriteLine();
                Console.WriteLine("Buscando os Dados na API Google - Fim - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                Console.WriteLine("Atualizado os Dados na Tabela SQL - Inicio - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                UpdateData(lstCepGeo);
                Console.WriteLine("Atualizado os Dados na Tabela SQL - Fim - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        static cep_geo_csv Api(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest req = (HttpWebRequest)WebRequest.CreateDefault(uri);

            req.Accept = "application/json";
            req.UserAgent = "json";
            req.Method = "GET";

            HttpWebResponse response = req.GetResponse() as HttpWebResponse;
            Stream responsedata = response.GetResponseStream();
            StreamReader responsereader = new StreamReader(responsedata);
            string retorno = responsereader.ReadToEnd();

            var x = JsonConvert.DeserializeObject<dynamic>(retorno);

            //x.results[0].geometry.bounds.northeast.lat;

            if ((string)x.status == "OK")
            {
                if (x.results[0].geometry.bounds == null)
                {
                    return new cep_geo_csv()
                    {
                        LATITUDE = x.results[0].geometry.location.lat.ToString().Replace(",", "."),
                        LONGITUDE = x.results[0].geometry.location.lng.ToString().Replace(",", "."),
                        VALIDACAO = null
                    };
                }
                else
                {
                    return new cep_geo_csv()
                    {
                        LATITUDE = x.results[0].geometry.bounds.northeast.lat.ToString().Replace(",", "."),
                        LONGITUDE = x.results[0].geometry.bounds.northeast.lng.ToString().Replace(",", "."),
                        VALIDACAO = null
                    };
                }
            }
            else
            {
                return null;
            }
        }

        static List<cep_geo_csv> GetData(string uf)
        {
            string query =
                "select CEP " +
                "from cep_geo_csv_230518 " +
                "where uf = @uf " +
                "and isnull(validacao, 'False') = 'False' ";

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
                "Latitude = @Latitude, " +
                "Longitude = @Longitude " +
                "where cep = @cep ";

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
                cmd.Parameters.AddWithValue("@Validacao", string.IsNullOrEmpty(parametros[i].VALIDACAO) ? "" : parametros[i].VALIDACAO);
                cmd.Parameters.AddWithValue("@cep", parametros[i].CEP);
                cmd.Parameters.AddWithValue("@Latitude", string.IsNullOrEmpty(parametros[i].LATITUDE) ? "" : parametros[i].LATITUDE);
                cmd.Parameters.AddWithValue("@Longitude", string.IsNullOrEmpty(parametros[i].LONGITUDE) ? "" : parametros[i].LONGITUDE);
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
        public string VALIDACAO { get; set; }
    }

}



