using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class ProcedurePack : BaseJson
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public BsonDocument ToDocument() 
        {
            var procedurePackDocument = new ProcedurePackDocument
            {
                Code = Code, 
                Description = Description
            };
            procedurePackDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);
            return procedurePackDocument.ToBsonDocument();
        }
    }

    public class ProcedurePackDocument : BaseDocument
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
