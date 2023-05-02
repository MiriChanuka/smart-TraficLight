using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using DAL;
using System.Net.Http;
using System;

namespace BL
{
    public static class blockBL

    {  // חישוב העומס  בקטע כביש עפ"י הצעדים הנדרשים:

     
        public static void RoadLoadCalculation(Block b, Car[] cars)
        {//צפיפות התנועה
            double TrafficDensity = b.length / totalLength(cars);
            //עומס התנועה
            b.movement = TrafficDensity* theAverageSpeed(cars);
        }
        //מקבלת מערך של הרכבים שנמצאים בכביש מסוים חזרת האורך הכולל של האורכים בקטע כביש מסוים כולל מרקח התגובה שלהם
        public static double totalLength(Car[] cars)
        {
            if (cars == null || cars.Length == 0)
            {
                return 0;
            }

            double totalLength = 0;
            foreach (Car car in cars)
            {
                totalLength += car.carLength+(2/60)*car.speed;
            }

            return totalLength;
        }
       //פןנקציה שמחשבת ממוצע המהירויות של הרכבים
        public static double theAverageSpeed(Car[] cars)
        {
            if (cars == null || cars.Length == 0)
            {
                return 0;
            }

            double totalspeeds = 0;
            foreach (Car car in cars)
            {
                totalspeeds += car.speed ;
            }

            return totalspeeds/cars.Length;
        }
        ////ספירת רכבים 
        //public static int CountVehicles(string trafficData)
        //{
        //    // נפריד את נתוני התנועה לפי הסימן התאים
        //    string[] traffic = trafficData.Split(';');

        //    // נצביע על משתנה לצורך ספירת כלי הרכב
        //    int count = 0;

        //    // נעבור על כל נתוני התנועה ונחשב את סך כלי הרכב שעברו
        //    foreach (string data in traffic)
        //    {
        //        // נפריד את נתוני הרכב לפי הסימן הנכון
        //        string[] vehicleData = data.Split(',');

        //        // נוסיף את מספר הרכבים שעברו בקטע הכביש הנוכחי
        //        count += int.Parse(vehicleData[1]);
        //    }

        //    // נחזיר את סך כלי הרכב הכולל שעברו בכביש
        //    return count;
        //}
        //פונקציות התממשקות לDATA GOV

        //public static string GetCarProductCode2(string licensePlateNumber)
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
        //public static async System.Threading.Tasks.Task<string> GetCarProductCodeAsync(string licenseNumber)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync($"https://data.gov.il/api/3/action/datastore_search_sql?sql=SELECT%20manufacturer_and_model%20FROM%20%2205d5df5c-0a67-41f6-a3e6-3ec3c9f0a7fc%22%20WHERE%20license_plate LIKE%20%27{licenseNumber}%27"))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();

        //            JObject jsonResponse = JObject.Parse(apiResponse);

        //            JArray results = (JArray)jsonResponse["result"]["records"];

        //            if (results.Count > 0)
        //            {
        //                string manufacturerAndModel = (string)results[0]["manufacturer_and_model"];
        //                //Console.WriteLine(manufacturerAndModel);
        //                return manufacturerAndModel;
        //            }
        //            else
        //            {
        //                //Console.WriteLine("No results found.");
        //                return "No results found.";
        //            }
        //        }
        //    }


        //}


    }
}