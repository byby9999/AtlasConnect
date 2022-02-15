using AtlasConnect.JsonModels;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasConnect
{
    public class GenesisBusinessUpdates
    {
        public static void UpdateSurgeries(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            var surgeriesList = db.GetCollection<BsonDocument>("Surgery");

            var filter = Builders<BsonDocument>.Filter.Empty;

            //specify here fields to update: (chain .Set calls)
            var update = Builders<BsonDocument>.Update.Set("_partition", Configurations.PartitionDefault);
            
            Stopwatch s = new Stopwatch();
            s.Start();
            _ = surgeriesList.UpdateMany(filter, update);
            s.Stop();

            Console.WriteLine($"Updated 1 Surgery in {s.ElapsedMilliseconds} ms");
        }

        public static void UpdateSurgeries1By1(MongoClient client) 
        {
            long allTime = 0; 
            int ct = 0;
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            var surgeriesList = db.GetCollection<SurgeryDocument>("Surgery");
            
            var queryableCollection = surgeriesList.AsQueryable().ToList();

            foreach (var surgery in queryableCollection) 
            {
                var filter = Builders<SurgeryDocument>.Filter.Eq("InternId", surgery.SurgeryId);

                //specify here fields to update: (chain .Set calls)
                var update = Builders<SurgeryDocument>.Update.Set("_partition", Configurations.PartitionDefault);

                s.Start();
                surgeriesList.UpdateOne(filter, update);
                s.Stop();

                ct++;
                allTime += s.ElapsedMilliseconds;
            }

            Console.WriteLine($"Updated {ct} Surgery entities in {allTime} ms");
        }
    }
}
