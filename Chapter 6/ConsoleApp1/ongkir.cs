using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ConsoleApp1
{
    class ongkir
    {
        public static List<string> GetKotaList()
        {
            List<string> returnList = new List<string>();

            var client = new RestClient("https://api.rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);

            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");

            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = obj["rajaongkir"] as JsonObject;
            JsonArray CityListArray = rajaObj["results"] as JsonArray;

            foreach (JsonObject city  in CityListArray)
            {
                returnList.Add((string) city["city_name"]);
            }
            return returnList;
        }

        public static JsonArray GetKotaIDList()
        {
            var client = new RestClient("https://api.rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);

            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");

            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = obj["rajaongkir"] as JsonObject;
            JsonArray CityListArray = rajaObj["results"] as JsonArray;
            
            return CityListArray;
        }

        public static List<string> GetLayananList(int idAsal, int idTujuan, int berat, string kurir)
        {
            List<string> returnList = new List<string>();

            var client = new RestClient("https://api.rajaongkir.com/starter/cost");
            var request = new RestRequest(Method.POST);

            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            request.AddParameter("application/x-www-form-urlencoded",
                $"origin={idAsal.ToString()}&destination={idTujuan.ToString()}"+
                $"&weight={berat.ToString()}&courier={kurir}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = obj["rajaongkir"] as JsonObject;
            JsonArray resultArray = rajaObj["results"] as JsonArray;

            JsonObject courierInfo = resultArray[0] as JsonObject;
            JsonArray serviceArray = courierInfo["costs"] as JsonArray;

            foreach (JsonObject service in serviceArray)
            {
                string layanan = (string)courierInfo["name"];
                layanan += "-" + (string)service["service"];

                JsonArray detail = (JsonArray)service["cost"];
                JsonObject infoService = (JsonObject)detail[0];

                layanan += " Rp" + (infoService["value"]).ToString();
                layanan += " " + (string)infoService["etd"] + " Hari";
                returnList.Add(layanan);
            }
            return returnList;
        }
        
    }
}
