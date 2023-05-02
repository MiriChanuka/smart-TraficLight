using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class RedisConnectorHelperProgram
    {
       public RedisConnectorHelperProgram()
        {
            DeleteData();

           // Console.WriteLine("Saving random data in cache");
           //SaveBigData();

           // Console.WriteLine("Reading data from cache");
           // ReadData();

           // Console.ReadLine();
        }

    
    public static void ReadData()
        {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            var devicesCount = 10000;
            for (int i = 0; i < devicesCount; i++)
            {
                var value = cache.StringGet($"Device_Status:{i}");
                Console.WriteLine($"Valor={value}");
            }
        }

        public static void SaveBigData()
        {
            var devicesCount = 10000;
            var rnd = new Random();
            var cache = RedisConnectorHelper.Connection.GetDatabase();

            for (int i = 1; i < devicesCount; i++)
            {
                var value ="hi miriiiii";
                cache.StringSet("njndhvgisbi", value);
            }
        }

        public static void DeleteData()
        {

      
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            cache.Execute("FLUSHDB");

           
        }
    }

}

