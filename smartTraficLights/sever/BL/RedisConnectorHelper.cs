using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace BL
{
    public class RedisConnectorHelper
        {
        private static Lazy<ConnectionMultiplexer> lazyConnection;

        static RedisConnectorHelper()
            {
                RedisConnectorHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
                {
                    
                    return ConnectionMultiplexer.Connect("localhost:6379");
                });
            }


            public static ConnectionMultiplexer Connection
            {
                get
                {
                    return lazyConnection.Value;
                }
            }
        }


    
}
