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
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.Newtonsoft;
using StackExchange.Redis.Extensions.Core.Implementations;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core.DAG;
using Nancy;
using Nancy.Routing.Trie;

namespace DAL
{
    public class RoadGraph
    {
        public RoadGraph()
        {

        }


        public void createGraph()
        {
            var redis = ConnectionMultiplexer.Connect("localhost");
            var db = redis.GetDatabase();

            // Create graph
            //var graph = new ("mygraph");
            //graph.Nodes.Add(new Node("1", "Person", new Dictionary<string, object> { { "name", "Alice" }, { "age", 30 } }));
            //graph.Nodes.Add(new Node("2", "Person", new Dictionary<string, object> { { "name", "Bob" }, { "age", 40 } }));
            //graph.Edges.Add(new Edge("1", "2", "KNOWS", new Dictionary<string, object> { { "since", 2010 } }));

            //// Store graph in Redis
            //var graphCache = new GraphCache(db);
            //graphCache.Store(graph);





            //var redis = ConnectionMultiplexer.Connect("localhost");
            //var db = redis.GetDatabase();

            // Create graph
            //var graph = new Graph<TraficLight, Block>();

            //    Graph<NodeData, Node> graph = new Graph();
            //    graph.Nodes.Add(new Node("1", "Person", new Dictionary<string, object> { { "name", "Alice" }, { "age", 30 } }));
            //    graph.Nodes.Add(new Node("2", "Person", new Dictionary<string, object> { { "name", "Bob" }, { "age", 40 } }));
            //    graph.Edges.Add(new Edge("1", "2", "KNOWS", new Dictionary<string, object> { { "since", 2010 } }));

            //  *//  Store graph in Redis
            //   var graphCache = new GraphCache(db);
            //    graphCache.Store(graph);
            //}

            ////public void addGraph()
            //{
            //    // Connect to Neo4j database
            //    var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "neo4j"));
            //    var session = driver.AsyncSession();

            //    // Create nodes
            //    var nodeA = new { name = "Node A" };
            //    var nodeB = new { name = "Node B" };
            //    var nodeC = new { name = "Node C" };

            //    // Create relationships
            //    var relationshipAB = new { type = "KNOWS", weight = 0.5 };
            //    var relationshipBC = new { type = "LIKES", weight = 0.8 };

            //    // Add nodes and relationships to graph
            //    session.RunAsync("CREATE (a:Person {name: $nameA})-[:$typeAB {weight: $weightAB}]->(b:Person {name: $nameB})-[:$typeBC {weight: $weightBC}]->(c:Person {name: $nameC})",
            //new
            //{
            //    nameA = nodeA.name,
            //    nameB = nodeB.name,
            //    nameC = nodeC.name,
            //    typeAB = relationshipAB.type,
            //    weightAB = relationshipAB.weight,
            //    typeBC = relationshipBC.type,
            //    weightBC = relationshipBC.weight
            //});

            //    // Close session and driver
            //    session.CloseAsync();
            //    driver.CloseAsync();


            //    // Connect to Redis database
            //    var redisConfiguration = new RedisConfiguration()
            //    {
            //        AbortOnConnectFail = false,
            //        KeyPrefix = "graph:",
            //        Hosts = new RedisHost[]
            //        {
            //new RedisHost()
            //{
            //    Host = "localhost",
            //    Port = 6379
            //}
            //        }
            //    };
            //    var serializer = new NewtonsoftSerializer();
            //    var redisConnectionFactory = new RedisCacheConnectionPoolManager(redisConfiguration);
            //    var redisDatabase = new RedisDatabase(redisConnectionFactory, serializer);

            //    // Store graph in Redis
            //    var graph = session.RunAsync("MATCH (n) RETURN n").ToList();
            //    redisDatabase.Database.GraphAdd("mygraph", graph);

            //    // Close session and Redis connection
            //    session.Close();
            //    redisDatabase.Dispose();

            //}


        }
    }
}
