using MongoDB.Driver;

namespace AtlasConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = MongoClientSettings.FromConnectionString(
                Configurations.Chester_ChesterOrg_AWS_Cluster0);
            var client = new MongoClient(settings);

            //Inserts: client.Add___
            //Updates: client.Update___
            //Deletes: client.DeleteSurgeries

            //client.AddProcedures(Configurations.GenesisDb, true);
            //client.AddTheatres(Configurations.GenesisDb, true);
            //client.AddSurgeons(Configurations.GenesisDb, true);
            //client.AddSurgeries(Configurations.GenesisDb, true);
        }
    }
}
