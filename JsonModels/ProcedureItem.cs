using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class ProcedureItem : BaseJson
    {
        public string Id { get; set; }
        public string ProcedureId { get; set; }
        public string ItemId { get; set; }
        public string SurgeonId { get; set; }
        public string UnitOfMeasure { get; set; }
        public int RatioToBase { get; set; }
        public int Quantity { get; set; }

        public BsonDocument ToDocument() 
        {
            var procedureItemDoc = new ProcedureItemDocument
            {
                ProcedureId = ProcedureId,
                ItemId = ItemId,
                SurgeonId = SurgeonId,
                UnitOfMeasure = UnitOfMeasure,
                RatioToBase = RatioToBase,
                Quantity = Quantity
            };
            procedureItemDoc.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return procedureItemDoc.ToBsonDocument();
        }
    }

    public class ProcedureItemDocument : BaseDocument
    {
        public string ProcedureId { get; set; }
        public string ItemId { get; set; }
        public string SurgeonId { get; set; }
        public string UnitOfMeasure { get; set; }
        public int RatioToBase { get; set; }
        public int Quantity { get; set; }
    }
}
