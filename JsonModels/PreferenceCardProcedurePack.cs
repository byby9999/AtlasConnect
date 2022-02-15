using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class PreferenceCardProcedurePack : BaseJson
    {
        public int Id { get; set; }
        public int PreferenceCardId { get; set; }
        public string ProcedurePackId { get; set; }
        public bool Active { get; set; }
        public int Quantity { get; set; }

        public BsonDocument ToDocument() 
        {
            var preferenceCardPPDocument = new PreferenceCardProcedurePackDocument()
            {
                PreferenceCardId = PreferenceCardId,
                ProcedurePackId = ProcedurePackId,
                Active = Active,
                Quantity = Quantity
            };
            preferenceCardPPDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return preferenceCardPPDocument.ToBsonDocument();
        }
    }

    public class PreferenceCardProcedurePackDocument : BaseDocument
    {
        public int PreferenceCardId { get; set; }
        public string ProcedurePackId { get; set; }
        public bool Active { get; set; }
        public int Quantity { get; set; }
    }
}
