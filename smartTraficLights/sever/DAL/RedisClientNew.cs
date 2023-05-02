using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NRedisGraph;
using StackExchange.Redis;
using RedisGraphDotNet;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows;
using Neo4j.Driver;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.Newtonsoft;
using StackExchange.Redis.Extensions.Core.Implementations;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core.DAG;

namespace DAL
{
   public static class RedisClientNew
    {
        public static IDatabase db { get; set; }
        private static readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");

        public static void fffff()
        {
            //redis = ConnectionMultiplexer.Connect("localhost:6379");
            db = redis.GetDatabase();

        }
        public static void addCarToBD(Car c)
        {
            // Create a Redis hash for the car
            HashEntry[] carFields = new HashEntry[]
            {
         new HashEntry("idCar", c.idCar),
          new HashEntry("speed", c.speed),
         new HashEntry("carLength", c.carLength),
         new HashEntry("carWidth", c.carWidth),
         new HashEntry("locationOfCar", $"{ c.locationOfCar.x},{ c.locationOfCar.y}"),
    //new HashEntry("locationOfCar", c.locationOfCar)
            };
            db.HashSet("carCustomer:" + c.idCar, carFields);

            //db.GeoAdd("carLocations", c.locationOfCar.x, c.locationOfCar.y, c.idCar) ;
        }

        public static void addBlockToBD(Block b)
        {
            // create a Redis hash object for the car
            var blockHash = new HashEntry[]
            {
                new HashEntry("idBlock", b.idBlock),
                new HashEntry("length",  b.length),
                new HashEntry("width",  b.width),
                new HashEntry("numOfLane",  b.numOfLane),
                new HashEntry("movement",  b.movement),
                new HashEntry("numOfCars", b.numOfCars), 
                new HashEntry("idTraficLight",  b.idTraficLight),
          new HashEntry("locationOfBlock", $"{ b.locationOfBlock.x},{ b.locationOfBlock.y}"),


            };
            // set the car hash object in Redis
            db.HashSet("block"+b.idBlock, blockHash);

        }
public static void addTrafficLightsToBD(TraficLight t)
        {
            // create a Redis hash object for the traffic light
            var trafficLightHash = new HashEntry[]
            {
    new HashEntry("idTraficLight", t.idTraficLight),
    new HashEntry("location", $"{ t.location.x},{ t.location.y}"),
    new HashEntry("red",  t.red),
    new HashEntry("green",  t.green),
    new HashEntry("yellow",  t.yellow),
    new HashEntry("AFewSecondsToActivate",  t.AFewSecondsToActivate)
            };

            // set the traffic light hash object in Redis
            db.HashSet("traffic_lights"+ t.idTraficLight.ToString(), trafficLightHash);
        }
        public static void addPoprtiesCar()
        {

            // Define car properties for multiple cars
            var cars = new List<HashEntry[]>
{
    new HashEntry[]
    {
        new HashEntry("make", "Toyota"),
        new HashEntry("model", "Camry"),
        new HashEntry("year", 2022),
        //new HashEntry("color", "blue"),
        new HashEntry("length", 190),
        new HashEntry("width", 72)
    },
    new HashEntry[]
    {
        new HashEntry("make", "Honda"),
        new HashEntry("model", "Accord"),
        new HashEntry("year", 2023),
        //new HashEntry("color", "black"),
        new HashEntry("length", 192),
        new HashEntry("width", 73)
    },
        new HashEntry[]
    {
        new HashEntry("make", "Ford"),
        new HashEntry("model", "Mustang"),
        new HashEntry("year", 2022),
        new HashEntry("length", 4.7),
        new HashEntry("width", 1.8)
    },
    new HashEntry[]
    {
        new HashEntry("make", "Chevrolet"),
        new HashEntry("model", "Camaro"),
        new HashEntry("year", 2022),
        new HashEntry("length", 4.8),
        new HashEntry("width", 1.9)
    },
    new HashEntry[]
    {
        new HashEntry("make", "Nissan"),
        new HashEntry("model", "Altima"),
        new HashEntry("year", 2022),
        new HashEntry("color", "white"),
        new HashEntry("price", 26000),
        new HashEntry("length", 4.7),
        new HashEntry("width", 1.8)
    },
    new HashEntry[]
    {
        new HashEntry("make", "BMW"),
        new HashEntry("model", "3 Series"),
        new HashEntry("year", 2023),
        new HashEntry("length", 4.7),
        new HashEntry("width", 1.8)
    },
    new HashEntry[]
    {
        new HashEntry("make", "Mercedes-Benz"),
        new HashEntry("model", "C-Class"),
        new HashEntry("year", 2023),
        new HashEntry("length", 4.7),
        new HashEntry("width", 1.8)
    }

};
            // Add each car to the list
            foreach (var car in cars)
            {
             var carIndex = cars.IndexOf(car);
    db.HashSet($"car:{carIndex}", car);
    db.ListRightPush("carList", $"car:{carIndex}");
            }
            // Add each car to the list
            foreach (var car in cars)
            {
                db.ListRightPush("carList", car.Select(he => (RedisValue)he.Value).ToArray());
            }

            // Get all cars from the list
            var carList = db.ListRange("carList");

        }
        //הוספת רשימת כלי תחבורה עם אורכם 
        public static void addTheListOfMeansOfTransportWithTheirLength()
        {

            // Define car properties for multiple cars
            var TransportWithTheirLength = new List<HashEntry[]>
{
         new HashEntry[]
        {
        new HashEntry("kind", "Private car"),
        new HashEntry("Weight", 6000),
        new HashEntry("length", 5),
          new HashEntry("width", 1.9),
         },

        new HashEntry[]
         {
        new HashEntry("kind", "Intercity bus"),
        new HashEntry("Weight", 19000),
        new HashEntry("length", 14.5),
           new HashEntry("width", 2.5),
        },
     
    //  new HashEntry[]
    //{
    //    new HashEntry("kind", "City bus"),
    //    new HashEntry("Weight", 6000),
    //    new HashEntry("length", 5),
    //},

  
              //אופנוע
                new HashEntry[]
    {
        new HashEntry("kind", "motorcycle"),
        new HashEntry("Weight", 400),
        new HashEntry("length", 2.5),
           new HashEntry("width", 1),
    },
                //קלנועית
                    new HashEntry[]
    {
        new HashEntry("kind", "scooter"),
        new HashEntry("Weight", 2000),
        new HashEntry("length",5),
        new HashEntry("width", 1.9),
    },
         new HashEntry[]
         {
        new HashEntry("kind", "small car"),
        new HashEntry("Weight", 3000),
        new HashEntry("length", 4),
           new HashEntry("width", 1.8),
         },
                         //משאית
          new HashEntry[]
    {
        new HashEntry("kind", "truck"),
        new HashEntry("Weight", 12000),
        new HashEntry("length", 12),
           new HashEntry("width", 2.7),
    },
                 new HashEntry[]
    {
        new HashEntry("kind", "City bus with 2 parts"),
        new HashEntry("Weight", 25000),
        new HashEntry("length", 18.75),
           new HashEntry("width", 2.75),
    },
};
            // Add each car to the list
            foreach (var car in TransportWithTheirLength)
            {
                var carIndex = TransportWithTheirLength.IndexOf(car);
                db.HashSet($"TransportWithTheirLength:{carIndex}", car);
                db.ListRightPush("TransportWithTheirLengthList", $"TransportWithTheirLength:{carIndex}");
            }
            // Add each car to the list
            foreach (var car in TransportWithTheirLength)
            {
                db.ListRightPush("TransportWithTheirLengthList", car.Select(he => (RedisValue)he.Value).ToArray());
            }

            // Get all cars from the list
            var carList = db.ListRange("TransportWithTheirLengthList");

        }


        //פונקציה שמחזירה לי את אורך ורוחב סוג הרכב שהמשקל שלו הכי מתאים

        public static  Tuple<double, double>  GetTransportByWeight(int weight)
        {
            var values = db.HashValues("TransportWithTheirLengthList");

            TransportWithTheirLength result = null;
            int closestWeightDiff = int.MaxValue;

            foreach (var value in values)
            {
                var transport = JsonConvert.DeserializeObject<TransportWithTheirLength>(value);

                var weightDiff = Math.Abs(transport.Weight - weight);

                if (weightDiff < closestWeightDiff)
                {
                    closestWeightDiff = weightDiff;
                    result = transport;
                }
            }

            return new Tuple<double, double>( result.length,result.width);
        }

        public static HashEntry[] returnOneCarFromId(int carIndex)
        {
            return (HashEntry[])db.HashGetAll($"car:{carIndex}");
        }
        public static Double lengthOfCar(int carIndex)
        {
            return (double)db.HashGet($"car:{carIndex}", "length");
        }
        public static Double widthOfCar(int carIndex)
        {
            return (double)db.HashGet($"car:{carIndex}", "width");
        }
        public static void AddData()
        {
            // Add data to a Redis hash
            var GRAPH = new RedisGraph(db);
            //RedisResult result = db.Execute("GRAPH.QUERY", "mygraph", "CREATE (:Person {name: 'Alice', age: 30})");
            //var createBobResult = await graph.QueryAsync("pets", "CREATE(:human{name:'Bob',age:32})");
            //RedisGraphAPI graphnew = RedisGraphAPI(db);
            //db.HashSet("myhash", new HashEntry[] {
            //new HashEntry("field1", "value1"),
            //new HashEntry("field2", "value2")
            //});


            // יצירת גרף חדש בשם "roads"
            //DAGraph roadsGraph = new DAGraph();


            //    // Add data to a Redis list
            //db.StringSet("mykey", "myvalue");
            //db.ListRightPush("mylist", "value1");
            //db.ListRightPush("mylist", "value2");


            //RedisResult result = db.Execute("GRAPH.QUERY", "mygraph", "CREATE (:Person {name: 'Alice', age: 30})");

        }
    }
}
