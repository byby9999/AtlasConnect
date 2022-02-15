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
    public class GenesisBusiness
    {
        public static void AddBodySide(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var bodySideCollection = db.GetCollection<BsonDocument>("BodySide");

            string bodySideJson = File.ReadAllText(Paths.BodySide);

            var bodySideModels = JsonConvert.DeserializeObject<List<BodySide>>(bodySideJson).ToList();

            var bodySideDocuments = new List<BsonDocument>();

            foreach (var bodySide in bodySideModels)
            {
                var doc = bodySide.ToDocument();
                bodySideDocuments.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            bodySideCollection.InsertMany(bodySideDocuments);
            s.Stop();

            Console.WriteLine($"Inserted {bodySideDocuments.Count} BodySide entities");
        }

        public static void AddBodySites(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var bodySiteCollection = db.GetCollection<BsonDocument>("BodySite");

            string bodySiteJson = File.ReadAllText(Paths.BodySite);

            var bodySiteModels = JsonConvert.DeserializeObject<List<BodySite>>(bodySiteJson).ToList();

            var bodySiteDocuments = new List<BsonDocument>();

            foreach (var bodySite in bodySiteModels)
            {
                var doc = bodySite.ToDocument();
                bodySiteDocuments.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            bodySiteCollection.InsertMany(bodySiteDocuments);
            s.Stop();

            Console.WriteLine($"Inserted {bodySiteDocuments.Count} BodySite entities");
        }

        public static void AddItems(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var itemCollection = db.GetCollection<BsonDocument>("Item");

            string itemJson = File.ReadAllText(Paths.Item);

            var itemModels = JsonConvert.DeserializeObject<List<Item>>(itemJson).ToList();

            var itemDocuments = new List<BsonDocument>();

            foreach (var item in itemModels)
            {
                var doc = item.ToDocument();
                itemDocuments.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            itemCollection.InsertMany(itemDocuments);
            s.Stop();

            Console.WriteLine($"Inserted {itemDocuments.Count} Item entities");
        }

        public static void AddItemBarcodes(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var itemCollection = db.GetCollection<BsonDocument>("ItemBarcode");

            string itemBarcodesJson = File.ReadAllText(Paths.Itembarcode);

            var itemBarcodeModels = JsonConvert.DeserializeObject<List<ItemBarcode>>(itemBarcodesJson).ToList();

            var itemDocuments = new List<BsonDocument>();

            foreach (var item in itemBarcodeModels)
            {
                var doc = item.ToDocument();
                itemDocuments.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            itemCollection.InsertMany(itemDocuments);
            s.Stop();

            Console.WriteLine($"Inserted {itemDocuments.Count} ItemBarcode entities");
        }

        public static void AddLocations(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var locationCollection = db.GetCollection<BsonDocument>("Location");

            string locationsJson = File.ReadAllText(Paths.Location);

            var locationModels = JsonConvert.DeserializeObject<List<Location>>(locationsJson).ToList();

            var locationDocuments = new List<BsonDocument>();

            foreach (var location in locationModels)
            {
                var doc = location.ToDocument();
                locationDocuments.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            locationCollection.InsertMany(locationDocuments);
            s.Stop();

            Console.WriteLine($"Inserted {locationDocuments.Count} Location entities");
        }

        public static void AddLocationItems(MongoClient client)
        {
            //var db = client.GetDatabase(Configurations.DefaultDatabase);
            //var locationItemCollection = db.GetCollection<BsonDocument>("LocationItem");

            //string locationItemsJson = File.ReadAllText(Paths.LocationItem);

            //var locationItemModels = JsonConvert.DeserializeObject<List<LocationItem>>(locationItemsJson).ToList();

            //var locationDocuments = new List<BsonDocument>();

            //foreach (var locationItem in locationItemModels)
            //{
            //    var doc = locationItem.ToDocument();
            //    locationDocuments.Add(doc);
            //}

            //Stopwatch s = new Stopwatch();
            //s.Start();
            //locationItemCollection.InsertMany(locationDocuments);
            //s.Stop();

            //Console.WriteLine($"Inserted {locationDocuments.Count} LocationItem entities");
        }

        public static void AddLocationUsers(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var locationUserCollection = db.GetCollection<BsonDocument>("LocationUser");

            string locationUsersJson = File.ReadAllText(Paths.LocationUser);

            var locationUserModels = JsonConvert.DeserializeObject<List<LocationUser>>(locationUsersJson).ToList();

            var locationUserDocuments = new List<BsonDocument>();

            foreach (var locationUser in locationUserModels)
            {
                var doc = locationUser.ToDocument();
                locationUserDocuments.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            locationUserCollection.InsertMany(locationUserDocuments);
            s.Stop();

            Console.WriteLine($"Inserted {locationUserDocuments.Count} LocationUser entities");
        }

        public static void AddOrganisationSiteUsers(MongoClient client)
        {
            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var organisationSiteUserCollection = db.GetCollection<BsonDocument>("OrganisationSiteUser");

            string organisationSiteUserJson = File.ReadAllText(Paths.OrganisationSiteUser);

            var organisationSiteUserModels = JsonConvert.DeserializeObject<List<OrganisationSiteUser>>(organisationSiteUserJson).ToList();

            var organisationSiteUserDocuments = new List<BsonDocument>();

            foreach (var organisationSiteUser in organisationSiteUserModels)
            {
                var doc = organisationSiteUser.ToDocument();
                organisationSiteUserDocuments.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            organisationSiteUserCollection.InsertMany(organisationSiteUserDocuments);
            s.Stop();

            Console.WriteLine($"Inserted {organisationSiteUserDocuments.Count} OrganisationSiteUser entities");
        }

        public static void AddPatients(MongoClient client)
        {
            string entity = "Patient";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.Patient);

            var models = JsonConvert.DeserializeObject<List<Patient>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} ${entity} entities");
        }

        public static void AddPreferenceCards(MongoClient client)
        {
            string entity = "PreferenceCard";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.PreferenceCard);

            var models = JsonConvert.DeserializeObject<List<PreferenceCard>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddPreferenceCardItems(MongoClient client)
        {
            string entity = "PreferenceCardItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.PreferenceCardItem);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddPreferenceCardProcedures(MongoClient client)
        {
            string entity = "PreferenceCardProcedure";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.PreferenceCardProcedure);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardProcedure>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddPreferenceCardProcedurePacks(MongoClient client)
        {
            string entity = "PreferenceCardProcedurePack";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.PreferenceCardProcedurePack);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardProcedurePack>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddPreferenceCardSites(MongoClient client)
        {
            string entity = "PreferenceCardSite";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.PreferenceCardSite);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardSite>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddPreferenceCardSurgeons(MongoClient client)
        {
            string entity = "PreferenceCardSurgeon";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.PreferenceCardSurgeon);

            var models = JsonConvert.DeserializeObject<List<PreferenceCardSurgeon>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddProcedures(MongoClient client)
        {
            string entity = "Procedure";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.Procedure);

            var models = JsonConvert.DeserializeObject<List<Procedure>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddProcedureItems(MongoClient client)
        {
            string entity = "ProcedureItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.Procedure);

            var models = JsonConvert.DeserializeObject<List<ProcedureItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddProcedurePacks(MongoClient client)
        {
            string entity = "ProcedurePack";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.ProcedurePack);

            var models = JsonConvert.DeserializeObject<List<ProcedurePack>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddProcedureSurgeons(MongoClient client)
        {
            string entity = "ProcedureSurgeon";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.ProcedureSurgeon);

            var models = JsonConvert.DeserializeObject<List<ProcedureSurgeon>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddRolePermissions(MongoClient client)
        {
            string entity = "RolePermission";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.RolePermissions);

            var models = JsonConvert.DeserializeObject<List<RolePermission>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddSuppliers(MongoClient client)
        {
            string entity = "Supplier";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.Supplier);

            var models = JsonConvert.DeserializeObject<List<Supplier>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddSupplierItems(MongoClient client)
        {
            string entity = "SupplierItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.SupplierItem);

            var models = JsonConvert.DeserializeObject<List<SupplierItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");

        }

        public static void AddSurgeons(MongoClient client)
        {
            string entity = "Surgeon";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.Surgeon);

            var models = JsonConvert.DeserializeObject<List<Surgeon>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddSurgeryItemStatusReasons(MongoClient client)
        {
            string entity = "SurgeryItemStatusReason";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.SurgeryItemStatusReason);

            var models = JsonConvert.DeserializeObject<List<SurgeryItemStatusReason>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddSurgerySchedules(MongoClient client)
        {
            string entity = "SurgerySchedule";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.SurgerySchedule);

            var models = JsonConvert.DeserializeObject<List<SurgerySchedule>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddSurgeryScheduleSecondaryProcedures(MongoClient client)
        {
            string entity = "SurgeryScheduleSecondaryProcedure";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.SurgeryScheduleSecondaryProcedure);

            var models = JsonConvert.DeserializeObject<List<SurgeryScheduleSecondaryProcedure>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddTheatres(MongoClient client)
        {
            string entity = "Theatre";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.Theatre);

            var models = JsonConvert.DeserializeObject<List<Theatre>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddTheatreStaffs(MongoClient client)
        {
            string entity = "TheatreStaff";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.TheatreStaff);

            var models = JsonConvert.DeserializeObject<List<TheatreStaff>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddSurgeries(MongoClient client)
        {
            string entity = "Surgery";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.Surgery);

            var models = JsonConvert.DeserializeObject<List<Surgery>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddSurgeryItems(MongoClient client)
        {
            string entity = "SurgeryItem";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.SurgeryItems);

            var models = JsonConvert.DeserializeObject<List<SurgeryItem>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }

        public static void AddProcedureProcedurePack(MongoClient client)
        {
            string entity = "ProcedureProcedurePack";

            var db = client.GetDatabase(Configurations.DefaultDatabase);
            var collection = db.GetCollection<BsonDocument>(entity);

            string json = File.ReadAllText(Paths.ProcedureProcedurePack);

            var models = JsonConvert.DeserializeObject<List<ProcedureProcedurePack>>(json).ToList();

            var documents = new List<BsonDocument>();

            foreach (var item in models)
            {
                var doc = item.ToDocument();
                documents.Add(doc);
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            collection.InsertMany(documents);
            s.Stop();

            Console.WriteLine($"Inserted {documents.Count} {entity} entities");
        }
    }
}
