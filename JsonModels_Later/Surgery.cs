using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels_Later
{
    public class SurgeryEntity 
    {
        public ObjectId _id { get; set; }
        public string EndTime { get; set; }
        public string GRSN { get; set; }
        public string Notes { get; set; }
        public string PatientId { get; set; }
        public SurgeryEntity_Procedure Procedure { get; set; }
        public IList<SurgeryEntity_SecondaryProcedures> SecondaryProcedures { get; }
        public string StartTime { get; set; }
        public string State { get; set; }
        public SurgeryEntity_Surgeon Surgeon { get; set; }
        public string SurgeryId { get; set; }
        public string SurgeryScheduleId { get; set; }
        public string SyncState { get; set; }
        public string TenantId { get; set; }
        public SurgeryEntity_Theatre Theatre { get; set; }
    }

    public class SurgeryEntity_Procedure
    {
        public string Bodyside { get; set; }
        public string Code { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class SurgeryEntity_SecondaryProcedures
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string SecondaryProcedureId { get; set; }
    }

    public class SurgeryEntity_Surgeon
    {
        public string Code { get; set; }
        public string Forename { get; set; }
        public string ID { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
    }

    public class SurgeryEntity_Theatre 
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
    }
}
