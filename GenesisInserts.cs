using AtlasConnect.JsonModels;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasConnect
{
    public static class GenesisInserts
    {
        public static void AddBodySide(this MongoClient client, bool batchMode)
        {
            string objectName = "BodySide";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.BodySide);

            var models = JsonConvert.DeserializeObject<List<BodySide>>(json).ToList();

            var documents = new List<BsonDocument>();

                foreach (var model in models)
                {
                    var doc = model.ToDocument();
                    documents.Add(doc);
                }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else 
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents) 
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
            
        }

        public static void AddBodySites(this MongoClient client, bool batchMode)
        {
            string objectName = "BodySite";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.BodySite);

            var models = JsonConvert.DeserializeObject<List<BodySite>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else 
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddItems(this MongoClient client, bool batchMode)
        {
            string objectName = "Item";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Item);

            var models = JsonConvert.DeserializeObject<List<Item>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddItemBarcodes(this MongoClient client, bool batchMode)
        {
            string objectName = "ItemBarcode";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Itembarcode);

            var models = JsonConvert.DeserializeObject<List<ItemBarcode>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode) 
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else 
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddLocations(this MongoClient client, bool batchMode)
        {
            string objectName = "Location";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Location);

            var models = JsonConvert.DeserializeObject<List<Location>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddLocationItems(this MongoClient client, bool batchMode)
        {
            string objectName = "LocationItem";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.LocationItem);

            var models = JsonConvert.DeserializeObject<List<LocationItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddLocationUsers(this MongoClient client, bool batchMode)
        {
            string objectName = "LocationUser";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.LocationUser);

            var models = JsonConvert.DeserializeObject<List<LocationUser>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode) 
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddOrganisationSiteUsers(this MongoClient client, bool batchMode)
        {
            string objectName = "OrganisationSiteUser";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.OrganisationSiteUser);

            var models = JsonConvert.DeserializeObject<List<OrganisationSiteUser>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode) 
            { 
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} {objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddPatients(this MongoClient client, bool batchMode)
        {
            string objectName = "Patient";
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Patient);

            var models = JsonConvert.DeserializeObject<List<Patient>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode)
            { 
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else 
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddPreferenceCards(this MongoClient client, bool batchMode)
        {
            string objectName = "PreferenceCard";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.PreferenceCard);

            var models = JsonConvert.DeserializeObject<List<PreferenceCard>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddPreferenceCardItems(this MongoClient client, bool batchMode)
        {
            string objectName = "PreferenceCardItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.PreferenceCardItem);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }
            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddPreferenceCardProcedures(this MongoClient client, bool batchMode)
        {
            string objectName = "PreferenceCardProcedure";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.PreferenceCardProcedure);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardProcedure>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddPreferenceCardProcedurePacks(this MongoClient client, bool batchMode)
        {
            string objectName = "PreferenceCardProcedurePack";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.PreferenceCardProcedurePack);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardProcedurePack>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddPreferenceCardSites(this MongoClient client, bool batchMode)
        {
            string objectName = "PreferenceCardSite";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.PreferenceCardSite);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardSite>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddPreferenceCardSurgeons(this MongoClient client, bool batchMode)
        {
            string objectName = "PreferenceCardSurgeon";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.PreferenceCardSurgeon);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardSurgeon>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddProcedures(this MongoClient client, bool batchMode)
        {
            string objectName = "Procedure";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Procedure);

            var models = JsonConvert.DeserializeObject<List<Procedure>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddProcedureItems(this MongoClient client, bool batchMode)
        {
            string objectName = "ProcedureItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Procedure);

            var models = JsonConvert.DeserializeObject<List<ProcedureItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddProcedurePacks(this MongoClient client, bool batchMode)
        {
            string objectName = "ProcedurePack";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.ProcedurePack);

            var models = JsonConvert.DeserializeObject<List<ProcedurePack>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddProcedureSurgeons(this MongoClient client, bool batchMode)
        {
            string objectName = "ProcedureSurgeon";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.ProcedureSurgeon);

            var models = JsonConvert.DeserializeObject<List<ProcedureSurgeon>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddRolePermissions(this MongoClient client, bool batchMode)
        {
            string objectName = "RolePermission";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.RolePermissions);

            var models = JsonConvert.DeserializeObject<List<RolePermission>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSuppliers(this MongoClient client, bool batchMode)
        {
            string objectName = "Supplier";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Supplier);

            var models = JsonConvert.DeserializeObject<List<Supplier>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSupplierItems(this MongoClient client, bool batchMode)
        {
            string objectName = "SupplierItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.SupplierItem);

            var models = JsonConvert.DeserializeObject<List<SupplierItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSurgeons(this MongoClient client, bool batchMode)
        {
            string objectName = "Surgeon";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Surgeon);

            var models = JsonConvert.DeserializeObject<List<Surgeon>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSurgeryItemStatusReasons(this MongoClient client, bool batchMode)
        {
            string objectName = "SurgeryItemStatusReason";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.SurgeryItemStatusReason);

            var models = JsonConvert.DeserializeObject<List<SurgeryItemStatusReason>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSurgerySchedules(this MongoClient client, bool batchMode)
        {
            string objectName = "SurgerySchedule";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.SurgerySchedule);

            var models = JsonConvert.DeserializeObject<List<SurgerySchedule>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSurgeryScheduleSecondaryProcedures(this MongoClient client, bool batchMode)
        {
            string objectName = "SurgeryScheduleSecondaryProcedure";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.SurgeryScheduleSecondaryProcedure);

            var models = JsonConvert.DeserializeObject<List<SurgeryScheduleSecondaryProcedure>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddTheatres(this MongoClient client, bool batchMode)
        {
            string objectName = "Theatre";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Theatre);

            var models = JsonConvert.DeserializeObject<List<Theatre>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddTheatreStaffs(this MongoClient client, bool batchMode)
        {
            string objectName = "TheatreStaff";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.TheatreStaff);

            var models = JsonConvert.DeserializeObject<List<TheatreStaff>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSurgeries(this MongoClient client, bool batchMode)
        {
            string objectName = "Surgery";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.Surgery);

            var models = JsonConvert.DeserializeObject<List<Surgery>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddSurgeryItems(this MongoClient client, bool batchMode)
        {
            string objectName = "SurgeryItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.SurgeryItems);

            var models = JsonConvert.DeserializeObject<List<SurgeryItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }

        public static void AddProcedureProcedurePack(this MongoClient client, bool batchMode)
        {
            string objectName = "ProcedureProcedurePack";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(objectName);

            string json = File.ReadAllText(Paths.ProcedureProcedurePack);

            var models = JsonConvert.DeserializeObject<List<ProcedureProcedurePack>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var model in models)
            {
                var doc = model.ToDocument();
                documents.Add(doc);
            }

            if (batchMode)
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                collection.InsertMany(documents);
                s.Stop();

                Console.WriteLine($"Inserted {documents.Count} ${objectName} entities in {s.ElapsedMilliseconds} ms (batch)");
            }
            else
            {
                long allTime = 0;
                int ct = 0;
                foreach (var item in documents)
                {
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    collection.InsertOne(item);
                    s.Stop();

                    ct++;
                    allTime += s.ElapsedMilliseconds;
                }

                Console.WriteLine($"Inserted {ct} {objectName} entities in {allTime} ms (avg { allTime / ct } ms / entity)");
            }
        }
    }
}
