using MongoDB.Driver;
using System;

namespace AtlasConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = MongoClientSettings.FromConnectionString(Configurations.MongoCluster_Chester_GenesisTest_AWS);
            var client = new MongoClient(settings);

            //Inserts: client.Add___
            //Updates: client.Update___
            
        }
    }
}
