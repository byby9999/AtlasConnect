using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class SurgeryScheduleSecondaryProcedure : BaseJson
    {
        public string Id { get; set; }
        public string SurgeryScheduleId { get; set; }
        public string ProcedureId { get; set; }
        public string PreferenceCardId { get; set; }

        public BsonDocument ToDocument()
        {
            int preferenceCardId = 1;
            int.TryParse(PreferenceCardId, out preferenceCardId);
            var doc = new SurgeryScheduleSecondaryProcedureDocument
            {
                SurgeryScheduleId = SurgeryScheduleId,
                ProcedureId = ProcedureId,
                PreferenceCardId = preferenceCardId
            };
            doc.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return doc.ToBsonDocument();
        }
    }

    public class SurgeryScheduleSecondaryProcedureDocument : BaseDocument
    {
        public string SurgeryScheduleId { get; set; }
        public string ProcedureId { get; set; }
        public int PreferenceCardId { get; set; }
    }
}