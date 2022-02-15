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
            GenesisBusiness.AddLocations(client);
            GenesisBusiness.AddLocationItems(client);
            GenesisBusiness.AddLocationUsers(client);
            GenesisBusiness.AddOrganisationSiteUsers(client);
            GenesisBusiness.AddPatients(client);
            GenesisBusiness.AddPreferenceCards(client);
            GenesisBusiness.AddPreferenceCardItems(client);
            GenesisBusiness.AddPreferenceCardProcedures(client);
            GenesisBusiness.AddPreferenceCardProcedurePacks(client);
            GenesisBusiness.AddPreferenceCardSites(client);
            GenesisBusiness.AddPreferenceCardSurgeons(client);
            GenesisBusiness.AddProcedures(client);
            GenesisBusiness.AddProcedureItems(client);
            GenesisBusiness.AddProcedurePacks(client);
            GenesisBusiness.AddProcedureSurgeons(client);
            GenesisBusiness.AddRolePermissions(client);
            GenesisBusiness.AddSuppliers(client);
            GenesisBusiness.AddSupplierItems(client);
            GenesisBusiness.AddSurgeons(client);
            GenesisBusiness.AddSurgeryItemStatusReasons(client);
            GenesisBusiness.AddSurgerySchedules(client);
            GenesisBusiness.AddSurgeryScheduleSecondaryProcedures(client);
            GenesisBusiness.AddTheatres(client);
            GenesisBusiness.AddTheatreStaffs(client);
            GenesisBusiness.AddSurgeries(client);
            GenesisBusiness.AddSurgeryItems(client);
            */
        }
    }
}
