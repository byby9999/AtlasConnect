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
            GenesisInserts.AddLocations(client);
            GenesisInserts.AddLocationItems(client);
            GenesisInserts.AddLocationUsers(client);
            GenesisInserts.AddOrganisationSiteUsers(client);
            GenesisInserts.AddPatients(client);
            GenesisInserts.AddPreferenceCards(client);
            GenesisInserts.AddPreferenceCardItems(client);
            GenesisInserts.AddPreferenceCardProcedures(client);
            GenesisInserts.AddPreferenceCardProcedurePacks(client);
            GenesisInserts.AddPreferenceCardSites(client);
            GenesisInserts.AddPreferenceCardSurgeons(client);
            GenesisInserts.AddProcedures(client);
            GenesisInserts.AddProcedureItems(client);
            GenesisInserts.AddProcedurePacks(client);
            GenesisInserts.AddProcedureSurgeons(client);
            GenesisInserts.AddRolePermissions(client);
            GenesisInserts.AddSuppliers(client);
            GenesisInserts.AddSupplierItems(client);
            GenesisInserts.AddSurgeons(client);
            GenesisInserts.AddSurgeryItemStatusReasons(client);
            GenesisInserts.AddSurgerySchedules(client);
            GenesisInserts.AddSurgeryScheduleSecondaryProcedures(client);
            GenesisInserts.AddTheatres(client);
            GenesisInserts.AddTheatreStaffs(client);
            GenesisInserts.AddSurgeries(client);
            GenesisInserts.AddSurgeryItems(client);
            */

            //GenesisUpdates.UpdateSurgeries(client, false);

        }
    }
}
