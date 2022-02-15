using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class ProcedureProcedurePack : BaseJson
    {
        public string Id { get; set; }
        public string ProcedurePackId { get; set; }
        public string ProcedureId { get; set; }
        public string SurgeonId { get; set; }

        public BsonDocument ToDocument()
        {
            var procedurePackDocument = new ProcedureProcedurePackDocument
            {
                ProcedurePackId = ProcedurePackId,
                ProcedureId = ProcedureId,
                SurgeonId = SurgeonId

            };
            procedurePackDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return procedurePackDocument.ToBsonDocument();
        }
    }

    public class ProcedureProcedurePackDocument : BaseDocument
    {
        public string ProcedurePackId { get; set; }
        public string ProcedureId { get; set; }
        public string SurgeonId { get; set; }
    }
}
