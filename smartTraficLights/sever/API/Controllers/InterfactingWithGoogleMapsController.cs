using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace API.Controllers
{
    public class InterfactingWithGoogleMapsController : ApiController
    {
        public string DistanceURL(string origin ,string dest)
        {
            string API_KEY = "";
            string URL = "http://maps.googlepis.com/maps/api/distancematrix/json?origins=" + origin
                + "&destinations=" + dest +
                "&units=imperial&mode=driving" +
                "&key=" + API_KEY;
            return URL;

        }

        public async Task<string> GetDistance(LocationClass l1, LocationClass l2)
        {
            HttpClient http = new HttpClient();

            string strL1 = l1.PointLatitudeLoctionX + "" + l1.PointLatitudeLoctiony;

            string strL2 = l2.PointLatitudeLoctionX + "" + l2.PointLatitudeLoctiony;
            var responseDistance = await http.GetAsync(DistanceURL(strL1, strL2));
            if (responseDistance.IsSuccessStatusCode)
            {
                var myResult = responseDistance.Content.ReadAsStringAsync();
                JsonFormat jsonResult = JsonConvert.DeserializeObject<>;
                return jsonResult.rows[0].elemnts[0].distance.text;

            }

            //if not success;
            return "";
        }
    }
}
