using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasConnect
{
    public class Configurations
    {
        public const string MongoCluster_Chester_GenesisTest_AWS = ""; //do not commit value

        public const string DefaultPartition = "61c058e5559668e69ad62a8d";

        public const string DefaultDatabase = "mydb";

        public static string[] OtherPartitions = new string[] 
        {
            "61c058e5559668e69ad62a8d",
            "61c066a7559668e69ad78346",
            "61c084f8f89724893240b892",
            "61c08508c0a82d01340e0458"
        };
    }

    public class Paths
    {
        public const string SurgeriesWithTenantFilePath = @"C:\Users\alexandra.savescu\Downloads\surgeries5000\surgeries5000.json";
        public const string SurgeriesWithTenantFilePath34 = @"C:\Users\alexandra.savescu\Downloads\surgeries5000\surgeries5000_34.json";
        
        public const string RootPath = @"C:\export2\";
        public const string OldRootPath = @"C:\export\";

        public static string BodySide = $"{RootPath}v_MobileBodySide.json";
        public static string BodySite = $"{RootPath}v_MobileBodySite.json";
        public static string Item = $"{RootPath}v_MobileItem.json";
        public static string Itembarcode = $"{RootPath}v_MobileItemBarcode.json";
        public static string Location = $"{RootPath}v_MobileLocation.json";
        public static string LocationItem = $"{RootPath}v_MobileLocationItem.json";
        public static string LocationUser = $"{RootPath}v_MobileLocationUser.json";
        public static string OrganisationSiteUser = $"{RootPath}v_MobileOrganisationSiteUser.json";

        public static string Patient = $"{OldRootPath}v_MobilePatient.json";

        public static string PreferenceCard = $"{RootPath}v_MobilePreferenceCard.json";
        public static string PreferenceCardItem = $"{RootPath}v_MobilePreferenceCardItem.json";
        public static string PreferenceCardProcedure = $"{RootPath}v_MobilePreferenceCardProcedure.json";
        public static string PreferenceCardProcedurePack = $"{RootPath}v_MobilePreferenceCardProcedurePack.json";

        public static string PreferenceCardSite = $"{OldRootPath}v_MobilePreferenceCardSite.json";

        public static string PreferenceCardSurgeon = $"{RootPath}v_MobilePreferenceCardSurgeon.json";
        public static string Procedure = $"{RootPath}v_MobileProcedure.json";
        public static string ProcedureItem = $"{RootPath}v_MobileProcedureItem.json";
        public static string ProcedurePack = $"{RootPath}v_MobileProcedurePack.json";
        public static string ProcedureProcedurePack = $"{RootPath}v_MobileProcedureProcedurePack.json";
        public static string ProcedureSurgeon = $"{RootPath}v_MobileProcedureSurgeon.json";
        public static string RolePermissions = $"{RootPath}v_MobileRolePermissions.json";
        public static string Supplier = $"{RootPath}v_MobileSupplier.json";
        public static string SupplierItem = $"{RootPath}v_MobileSupplierItem.json";
        public static string Surgeon = $"{RootPath}v_MobileSurgeon.json";
        public static string SurgeryItemStatusReason = $"{RootPath}v_MobileSurgeryItemStatusReason.json";

        public static string SurgerySchedule = $"{OldRootPath}v_MobileSurgerySchedule.json";

        public static string SurgeryScheduleSecondaryProcedure = $"{OldRootPath}v_MobileSurgeryScheduleSecondaryProcedure.json";

        public static string Theatre = $"{RootPath}v_MobileTheatre.json";
        public static string TheatreStaff = $"{RootPath}v_MobileTheatreStaff.json";

        public static string Surgery = $"{RootPath}vSurgery.json";
        public static string SurgeryItems = $"{RootPath}vSurgeryItems.json";

    }
}
