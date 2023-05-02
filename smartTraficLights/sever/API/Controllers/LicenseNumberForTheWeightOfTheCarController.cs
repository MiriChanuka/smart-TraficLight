using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [EnableCors()]
    [RoutePrefix("api/LicenseNumberForTheWeightOfTheCarController")]
    public class LicenseNumberForTheWeightOfTheCarController : ApiController
    {
        //פונקציה שמקבלת מספר רישוי ומחזירה את משרל הרכב
        [Route("FunctionsForFindingVehicleWeightAsync/{licenseNumber}")]
        public static async Task<int> FunctionsForFindingVehicleWeightAsync(string licenseNumber)
        {
            string a = await API.Controllers.LicenseNumberForTheWeightOfTheCarController.GetVehicleCodeByLicenseNumber("1000010");
            string a1 = await API.Controllers.LicenseNumberForTheWeightOfTheCarController.GetVehicleWeight(a);
    
            return int.Parse(a1);
                }

        //מקבלת מספר רישוי ומחזירה את קוד התוצר
        [Route("GetVehicleCodeByLicenseNumber/{licenseNumber}")]
      public static  async Task<string> GetVehicleCodeByLicenseNumber(string licenseNumber)
        {
            string resourceId = "053cea08-09bc-40ec-8f7a-156f0677aff3";
            string url = $"https://data.gov.il/api/3/action/datastore_search?resource_id={resourceId}&q={licenseNumber}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject jsonResponse = JObject.Parse(responseBody);

                    int totalResults = (int)jsonResponse["result"]["total"];
                    if (totalResults > 0)
                    {
                        JToken vehicleData = jsonResponse["result"]["records"][0];
                        string vehicleCode = (string)vehicleData["tozeret_cd"];
                        return vehicleCode;
                    }
                }

                return null;
            }
        }
        //פונקציה שמקבלת קוד תוצר של רכב ומחזירה את משקלו
       public static async Task<string> GetVehicleWeight(string productCode)
        {
        // יצירת כתובת ה-URL עם פרמטרי החיפוש
        string url = $"https://data.gov.il/api/3/action/datastore_search?resource_id=142afde2-6228-49f9-8a29-9b6c3a0cbe40&q={productCode}";

        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject jsonResponse = JObject.Parse(responseBody);

            int totalResults = (int)jsonResponse["result"]["total"];
            if (totalResults > 0)
            {
                JToken vehicleData = jsonResponse["result"]["records"][0];
                // מתאים לנתוני המכונית שלך, לפי המאפיינים שלהם במאגר הנתונים
                string weight = (string)vehicleData["mishkal_kolel"];
                    return weight;
            }
            else
            {
                return("No matching vehicles found");
            }
        }
        else
        {
          return($"Request failed with code {response.StatusCode}");
        }
    }


    //    פונקציה שמחזירה את 5 הראשונים
    //[Route("GetCarProduct")]
    //    public static void GetCarProduct(int a)
    //    {
    //        string url = "https://data.gov.il/api/action/datastore_search?resource_id={053cea08-09bc-40ec-8f7a-156f0677aff3}&filters={mispar_rechev:1000231}";
    //        WebClient client = new WebClient();
    //        string response = client.DownloadString(url);
    //        Console.WriteLine(response);
    //    }
        //[Route("GetCarProductCodeTRY/{licensePlateNumber}")]
        //public static string GetCarProductCodeTRY(string licensePlateNumber)
        //{
        //    string url = "https://data.gov.il/api/3/action/datastore_search?resource_id=9e1ecef1-5a29-4226-99a6-3eb26ec0e6c4&q=license_number:" + licensePlateNumber;
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "GET";

        //    try
        //    {
        //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //        StreamReader reader = new StreamReader(response.GetResponseStream());
        //        string responseText = reader.ReadToEnd();

        //        JObject jsonResponse = JObject.Parse(responseText);
        //        JArray results = (JArray)jsonResponse["result"]["records"];
        //        if (results.Count > 0)
        //        {
        //            return (string)results[0]["car_product_code"];
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }

        //       catch (WebException ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //        if (ex.Response != null)
        //        {
        //            using (var errorResponse = (HttpWebResponse)ex.Response)
        //            {
        //                using (var reader = new StreamReader(errorResponse.GetResponseStream()))
        //                {
        //                    string errorText = reader.ReadToEnd();
        //                  return("API Error Response: " + errorText);
        //                }
        //            }
        //        }
        //        return null;
        //    }
        //}
        //}
        //[Route("GetCarProductCode/{licensePlateNumber}")]
        //public static string GetCarProductCode(string licensePlateNumber)
        //{
        //    string url = "https://data.gov.il/api/3/action/datastore_search?resource_id=9e1ecef1-5a29-4226-99a6-3eb26ec0e6c4&q=license_number:" + licensePlateNumber;
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "GET";

        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //    StreamReader reader = new StreamReader(response.GetResponseStream());
        //    string responseText = reader.ReadToEnd();

        //    JObject jsonResponse = JObject.Parse(responseText);
        //    JArray results = (JArray)jsonResponse["result"]["records"];
        //    if (results.Count > 0)
        //    {
        //        return (string)results[0]["car_product_code"];
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //    [Route("aAsync")]
        //    public static async System.Threading.Tasks.Task aAsync()
        //    {

        //        string licenseNumber = "1000231";  // מספר הרישוי של הרכב שאתה מחפש
        //        string resourceId = "053cea08-09bc-40ec-8f7a-156f0677aff3";  // מזהה המקור במאגר הנתונים

        //        string url = $"https://data.gov.il/api/3/action/datastore_search?resource_id={resourceId}&q={licenseNumber}";

        //        HttpClient client = new HttpClient();
        //        HttpResponseMessage response = await client.GetAsync(url);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string responseBody = await response.Content.ReadAsStringAsync();
        //            JObject jsonResponse = JObject.Parse(responseBody);

        //            int totalResults = (int)jsonResponse["result"]["total"];
        //            if (totalResults > 0)
        //            {
        //                JToken vehicleData = jsonResponse["result"]["records"][0];
        //                // מתאים לנתוני המכונית שלך, לפי המאפיינים שלהם במאגר הנתונים
        //                string model = (string)vehicleData["Model"];
        //                string year = (string)vehicleData["Year"];

        //                Console.WriteLine($"Vehicle found: {model} ({year})");
        //            }
        //            else
        //            {
        //                Console.WriteLine("No matching vehicles found");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Request failed with code {response.StatusCode}");
        //        }

        //}
    }
}