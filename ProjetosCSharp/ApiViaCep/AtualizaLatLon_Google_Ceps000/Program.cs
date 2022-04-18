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

namespace AtualizaLatLon_Google_Ceps000
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string url;

            Console.WriteLine("Atualiza Latitude Longitude - Ceps final 000");  
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
                    object[] parameters = new object[] { lstCepGeo[i].TX_END_BAIRRO, lstCepGeo[i].NO_MUNICIPIO_RESIDENCIA, lstCepGeo[i].SG_UF_MUNICIPIO_RESIDENCIA };
                    //url = string.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0},{1},{2}&key=AIzaSyDydfOwFD9EvpX0ZeubKKMGskSkN6zi0mk", parameters);
                    url = string.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0},{1},{2}&key=AIzaSyAWA9QJs1IR27nr5aZw1Zg7Grqttc3yGIg", parameters);                    
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
                UpdateData(uf, lstCepGeo);
                Console.WriteLine();
                Console.WriteLine("Atualizado os Dados na Tabela SQL - Fim - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }


        }

        static Cep_000 Api(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest req = (HttpWebRequest)WebRequest.CreateDefault(uri);

            req.Accept = "application/json";
            req.UserAgent = "json";
            req.Method = "GET";

            req.Timeout = -1;


            try{            
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
                        return new Cep_000()
                        {
                            LATITUDE = x.results[0].geometry.location.lat.ToString().Replace(",", "."),
                            LONGITUDE = x.results[0].geometry.location.lng.ToString().Replace(",", "."),
                            VALIDACAO = null
                        };
                    }
                    else
                    {
                        return new Cep_000()
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
            catch
            {
                return null;
            }
        }

        static List<Cep_000> GetData(string uf)
        {
            string query =
            "select distinct" +
            "   cep.TX_END_BAIRRO , " +
            "   cep.NO_MUNICIPIO_RESIDENCIA, " +
            "   cep.CO_MUNICIPIO_RESIDENCIA, " +
            "   cep.SG_UF_MUNICIPIO_RESIDENCIA, " +
            "   cep.CEP, " +
            "   cep.LATITUDE, " +
            "   cep.LONGITUDE, " +
            "   cep.VALIDACAO " +
            "from " +
            "   CEPS_000_" + uf + " cep " +
            "where " +
            "   cep.SG_UF_MUNICIPIO_RESIDENCIA = @uf " +
            "   and (isnull(validacao, 'False') = 'False' or validacao = '') ";

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
                "Latitude = @Latitude, " +
                "Longitude = @Longitude " +
                "where sg_uf_municipio_residencia = @sg_uf_municipio_residencia " +
                "and cep = @tx_end_cep " +
                "and rtrim(ltrim(co_municipio_residencia)) = @co_municipio_residencia " +
                "and rtrim(ltrim(tx_end_bairro)) = rtrim(ltrim(@tx_end_bairro)) ";


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
                cmd.Parameters.AddWithValue("@Latitude", string.IsNullOrEmpty(parametros[i].LATITUDE) ? "0" : parametros[i].LATITUDE);
                cmd.Parameters.AddWithValue("@Longitude", string.IsNullOrEmpty(parametros[i].LONGITUDE) ? "0" : parametros[i].LONGITUDE);
                cmd.Parameters.AddWithValue("@sg_uf_municipio_residencia", string.IsNullOrEmpty(parametros[i].SG_UF_MUNICIPIO_RESIDENCIA) ? "" : parametros[i].SG_UF_MUNICIPIO_RESIDENCIA);
                cmd.Parameters.AddWithValue("@tx_end_bairro", string.IsNullOrEmpty(parametros[i].TX_END_BAIRRO) ? "" : parametros[i].TX_END_BAIRRO);
                cmd.Parameters.AddWithValue("@co_municipio_residencia", string.IsNullOrEmpty(parametros[i].CO_MUNICIPIO_RESIDENCIA) ? "" : parametros[i].CO_MUNICIPIO_RESIDENCIA);
                cmd.Parameters.AddWithValue("@tx_end_cep", string.IsNullOrEmpty(parametros[i].CEP) ? "" : parametros[i].CEP);

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
