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


namespace BL
{
    public class RedisClient
    {
//        public IDatabase db { get; set; }
//        private readonly ConnectionMultiplexer redis;

//        public RedisClient()
//        {
//            redis = ConnectionMultiplexer.Connect("localhost:6379");
//            db = redis.GetDatabase();


//        }
//        public void addPoprtiesCar()
//        {

//            // Define car properties for multiple cars
//            var cars = new List<HashEntry[]>
//{
//    new HashEntry[]
//    {
//        new HashEntry("make", "Toyota"),
//        new HashEntry("model", "Camry"),
//        new HashEntry("year", 2022),
//        //new HashEntry("color", "blue"),
//        new HashEntry("length", 190),
//        new HashEntry("width", 72)
//    },
//    new HashEntry[]
//    {
//        new HashEntry("make", "Honda"),
//        new HashEntry("model", "Accord"),
//        new HashEntry("year", 2023),
//        //new HashEntry("color", "black"),
//        new HashEntry("length", 192),
//        new HashEntry("width", 73)
//    },
//        new HashEntry[]
//    {
//        new HashEntry("make", "Ford"),
//        new HashEntry("model", "Mustang"),
//        new HashEntry("year", 2022),
//        new HashEntry("length", 4.7),
//        new HashEntry("width", 1.8)
//    },
//    new HashEntry[]
//    {
//        new HashEntry("make", "Chevrolet"),
//        new HashEntry("model", "Camaro"),
//        new HashEntry("year", 2022),
//        new HashEntry("length", 4.8),
//        new HashEntry("width", 1.9)
//    },
//    new HashEntry[]
//    {
//        new HashEntry("make", "Nissan"),
//        new HashEntry("model", "Altima"),
//        new HashEntry("year", 2022),
//        new HashEntry("color", "white"),
//        new HashEntry("price", 26000),
//        new HashEntry("length", 4.7),
//        new HashEntry("width", 1.8)
//    },
//    new HashEntry[]
//    {
//        new HashEntry("make", "BMW"),
//        new HashEntry("model", "3 Series"),
//        new HashEntry("year", 2023),
//        new HashEntry("length", 4.7),
//        new HashEntry("width", 1.8)
//    },
//    new HashEntry[]
//    {
//        new HashEntry("make", "Mercedes-Benz"),
//        new HashEntry("model", "C-Class"),
//        new HashEntry("year", 2023),
//        new HashEntry("length", 4.7),
//        new HashEntry("width", 1.8)
//    }

//};
//            // Add each car to the list
//            foreach (var car in cars)
//            {
//                var carIndex = cars.IndexOf(car);
//                db.HashSet($"car:{carIndex}", car);
//                db.ListRightPush("carList", $"car:{carIndex}");
//            }
//            // Add each car to the list
//            foreach (var car in cars)
//            {
//                db.ListRightPush("carList", car.Select(he => (RedisValue)he.Value).ToArray());
//            }

//            // Get all cars from the list
//            var carList = db.ListRange("carList");
           
//        }
//        public HashEntry[] returnOneCarFromId(int carIndex)
//        {
//           return (HashEntry[])db.HashGetAll($"car:{carIndex}");
//        }
//        public Double lengthOfCar(int carIndex)
//        {
//            return (double)db.HashGet($"car:{carIndex}", "length"); 
//        }
//        public Double widthOfCar(int carIndex)
//        {
//            return (double)db.HashGet($"car:{carIndex}", "width"); 
//        }
//        public void AddData()
//        {
//            // Add data to a Redis hash
//            var GRAPH = new RedisGraph(db);
//            //RedisResult result = db.Execute("GRAPH.QUERY", "mygraph", "CREATE (:Person {name: 'Alice', age: 30})");
//            //var createBobResult = await graph.QueryAsync("pets", "CREATE(:human{name:'Bob',age:32})");
//            //RedisGraphAPI graphnew = RedisGraphAPI(db);
//            //db.HashSet("myhash", new HashEntry[] {
//            //new HashEntry("field1", "value1"),
//            //new HashEntry("field2", "value2")
//            //});


//            // יצירת גרף חדש בשם "roads"
//            //DAGraph roadsGraph = new DAGraph();


//            //    // Add data to a Redis list
//            //db.StringSet("mykey", "myvalue");
//            //db.ListRightPush("mylist", "value1");
//            //db.ListRightPush("mylist", "value2");


//            //RedisResult result = db.Execute("GRAPH.QUERY", "mygraph", "CREATE (:Person {name: 'Alice', age: 30})");

//        }
    }
}
