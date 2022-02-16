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
    public static class GenesisUpdates
    {
        /// <summary>
        /// Update a subset of the collection
        /// </summary>
        /// <param name="client">the MongoClient</param>
        /// <param name="batchMode">
        /// If set to true, operations will be done in batch mode, i.e. with UpdateMany().
        /// If set to false, operations will be done 1 by 1, i.e. with repeated UpdateOne() calls.</param>
        /// <param name="percentDataToAffect">How much of the total data in collection to affect - Relevant only on 1-by-1 calls (batchMode=false)
        /// When batchMode=true, we affect 100% of data in collection</param>
        public static void UpdateSurgeries(this MongoClient client, bool batchMode, int percentDataToAffect = 10)
        {
            string objectName = "Surgery";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            
            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<SurgeryDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else 
            {
                long allTime = 0;
                int ct = 0;
                
                var documentsCollection = db.GetCollection<SurgeryDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<SurgeryDocument>.Filter.Eq("InternId", item.SurgeryId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect) 
                    {
                        break;
                    }   
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }
        public static void UpdateSurgeryItems(this MongoClient client, bool batchMode, int percentDataToAffect = 10)
        {
            string objectName = "SurgeryItem";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<SurgeryItemDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else
            {
                long allTime = 0;
                int ct = 0;

                var documentsCollection = db.GetCollection<SurgeryItemDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<SurgeryItemDocument>.Filter.Eq("InternId", item.InternId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void UpdateSupplierItems(this MongoClient client, bool batchMode, int percentDataToAffect = 10)
        {
            string objectName = "SupplierItem";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<SupplierItemDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else
            {
                long allTime = 0;
                int ct = 0;

                var documentsCollection = db.GetCollection<SupplierItemDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<SupplierItemDocument>.Filter.Eq("InternId", item.InternId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void UpdateLocationItems(this MongoClient client, bool batchMode, int percentDataToAffect = 10) 
        {
            string objectName = "LocationItem";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<LocationItemDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else
            {
                long allTime = 0;
                int ct = 0;

                var documentsCollection = db.GetCollection<LocationItemDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<LocationItemDocument>.Filter.Eq("InternId", item.InternId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void UpdateProcedureSurgeons(this MongoClient client, bool batchMode, int percentDataToAffect = 10)
        {
            string objectName = "ProcedureSurgeon";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<ProcedureSurgeonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else
            {
                long allTime = 0;
                int ct = 0;

                var documentsCollection = db.GetCollection<ProcedureSurgeonDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<ProcedureSurgeonDocument>.Filter.Eq("InternId", item.InternId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void UpdatePreferenceCardItems(this MongoClient client, bool batchMode, int percentDataToAffect = 10)
        {
            string objectName = "PreferenceCardItem";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<PreferenceCardItemDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else
            {
                long allTime = 0;
                int ct = 0;

                var documentsCollection = db.GetCollection<PreferenceCardItemDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<PreferenceCardItemDocument>.Filter.Eq("InternId", item.InternId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }
        public static void UpdateItemBarcodes(this MongoClient client, bool batchMode, int percentDataToAffect = 10)
        {
            string objectName = "ItemBarcode";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<ItemBarcodeDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else
            {
                long allTime = 0;
                int ct = 0;

                var documentsCollection = db.GetCollection<ItemBarcodeDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<ItemBarcodeDocument>.Filter.Eq("InternId", item.InternId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }
        public static void UpdateItems(this MongoClient client, bool batchMode, int percentDataToAffect = 10)
        {
            string objectName = "Item";
            Stopwatch s = new Stopwatch();
            var db = client.GetDatabase(Configurations.DefaultDatabase);

            //specify here fields to update: (chain .Set calls)
            var updates1By1 = Builders<ItemDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            var updatesBatch = Builders<BsonDocument>.Update
                .Set("_partition", Configurations.DefaultPartition);

            if (batchMode)
            {
                var collection = db.GetCollection<BsonDocument>(objectName);

                var filter = Builders<BsonDocument>.Filter.Empty;

                s.Start();
                var result = collection.UpdateMany(filter, updatesBatch);
                s.Stop();

                Console.WriteLine($"Updated {result.ModifiedCount} {objectName} entities in {s.ElapsedMilliseconds} ms");
            }
            else
            {
                long allTime = 0;
                int ct = 0;

                var documentsCollection = db.GetCollection<ItemDocument>(objectName);
                var queryableList = documentsCollection.AsQueryable().ToList();
                var countAll = queryableList.Count();

                foreach (var item in queryableList)
                {
                    var filter = Builders<ItemDocument>.Filter.Eq("InternId", item.InternId);

                    s.Start();
                    documentsCollection.UpdateOne(filter, updates1By1);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;

                    if (ct / countAll * 100 >= percentDataToAffect)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Updated {ct} {objectName} entities ({percentDataToAffect}%) in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }
    }
}
