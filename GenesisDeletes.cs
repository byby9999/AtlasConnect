using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Configuration;

namespace AtlasConnect
{
    public static class GenesisDeletes
    {
        public static void DeleteSurgeries(this MongoClient client)
        {
            string objectName = "Surgery";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);
            for(int i = 3; i >= 2; i--) 
            {
                string expr = "BULK_" + i;
                var filter = Builders<BsonDocument>.Filter.Regex("Reference", new BsonRegularExpression(expr));
                var result = collection.DeleteMany(filter);

                Console.WriteLine($"Deleted {result.DeletedCount} {objectName} entities: {expr}");
            }
            
        }

        public static void DeleteField(this MongoClient client) 
        {
            string objectName = "Surgery_v2";
            string fieldRemoved = "Duration";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            var filter = Builders<BsonDocument>.Filter.Empty;
            var updateDefinition = Builders<BsonDocument>.Update.Unset(fieldRemoved);

            collection.UpdateMany(filter, updateDefinition);

            Console.WriteLine($"Removed field {fieldRemoved} from objects in {objectName}");
        }
    }

}