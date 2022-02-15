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


            //Do what entity you want:
            /*GenesisBusiness.AddItemBarcodes(client);
            GenesisBusinessInserts.AddLocations(client);
            GenesisBusinessInserts.AddLocationItems(client);
            GenesisBusinessInserts.AddLocationUsers(client);
            GenesisBusinessInserts.AddOrganisationSiteUsers(client);
            GenesisBusinessInserts.AddPatients(client);
            GenesisBusinessInserts.AddPreferenceCards(client);
            GenesisBusinessInserts.AddPreferenceCardItems(client);
            GenesisBusinessInserts.AddPreferenceCardProcedures(client);
            GenesisBusinessInserts.AddPreferenceCardProcedurePacks(client);
            GenesisBusinessInserts.AddPreferenceCardSites(client);
            GenesisBusinessInserts.AddPreferenceCardSurgeons(client);
            GenesisBusinessInserts.AddProcedures(client);
            GenesisBusinessInserts.AddProcedureItems(client);
            GenesisBusinessInserts.AddProcedurePacks(client);
            GenesisBusinessInserts.AddProcedureSurgeons(client);
            GenesisBusinessInserts.AddRolePermissions(client);
            GenesisBusinessInserts.AddSuppliers(client);
            GenesisBusinessInserts.AddSupplierItems(client);
            GenesisBusinessInserts.AddSurgeons(client);
            GenesisBusinessInserts.AddSurgeryItemStatusReasons(client);
            GenesisBusinessInserts.AddSurgerySchedules(client);
            GenesisBusinessInserts.AddSurgeryScheduleSecondaryProcedures(client);
            GenesisBusinessInserts.AddTheatres(client);
            GenesisBusinessInserts.AddTheatreStaffs(client);
            GenesisBusinessInserts.AddSurgeries(client);
            GenesisBusinessInserts.AddSurgeryItems(client);
            */
        }
    }
}
