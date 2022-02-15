using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class PreferenceCardProcedure : BaseJson
    {
        public int Id { get; set; }
        public int PreferenceCardId { get; set; }
        public string ProcedureId { get; set; }
        public bool Active { get; set; }

        public BsonDocument ToDocument() 
        {
            var preferenceCardProcedureDocument = new PreferenceCardProcedureDocument()
            {
                PreferenceCardId = PreferenceCardId,
                ProcedureId = ProcedureId,
                Active = Active
            };
            preferenceCardProcedureDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return preferenceCardProcedureDocument.ToBsonDocument();
        }
    }

    public class PreferenceCardProcedureDocument : BaseDocument 
    {
        public int PreferenceCardId { get; set; }
        public string ProcedureId { get; set; }
        public bool Active { get; set; }
    }
}
