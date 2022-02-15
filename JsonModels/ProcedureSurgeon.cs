using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class ProcedureSurgeon : BaseJson
    {
        public string Id { get; set; }
        public string ProcedureSurgeonId { get; set; }
        public string ProcedureId { get; set; }
        public string SurgeonId { get; set; }

        public BsonDocument ToDocument()
        {
            var procedureSurgeonDocument = new ProcedureSurgeonDocument
            {
                ProcedureSurgeonId = ProcedureSurgeonId,
                ProcedureId = ProcedureId,
                SurgeonId = SurgeonId
            };
            procedureSurgeonDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);
            return procedureSurgeonDocument.ToBsonDocument();
        }
    }

    public class ProcedureSurgeonDocument : BaseDocument
    {
        public string ProcedureSurgeonId { get; set; }
        public string ProcedureId { get; set; }
        public string SurgeonId { get; set; }
    }
}
