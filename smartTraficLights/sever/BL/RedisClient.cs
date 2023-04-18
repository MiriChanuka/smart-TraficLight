using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace BL
{
    public class RedisClient
    {
        //public static conectRedis()
        //{

        //}
        public IDatabase db { get; set; }
        private readonly ConnectionMultiplexer redis;

        public RedisClient()
        {
            redis = ConnectionMultiplexer.Connect("localhost:6379");
             db = redis.GetDatabase();

        }

        //public void DoSomething()
        //{
        //    // Perform Redis operations
        //}

        //public  void AddData()
        //{
        //    // Add data to a Redis hash
        //    db.HashSet("myhash", new HashEntry[] {
        //    new HashEntry("field1", "value1"),
        //    new HashEntry("field2", "value2")
        //});

        //    // Add data to a Redis list
        //    db.ListRightPush("mylist", "value1");
        //    db.ListRightPush("mylist", "value2");
       
        //}
    }
}
