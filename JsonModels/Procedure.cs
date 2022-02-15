using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class Procedure : BaseJson
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool RequiresSpecificBodySide { get; set; }

        public BsonDocument ToDocument() 
        {
            var procedureDocument = new ProcedureDocument
            {
                Code = Code,
                Name = Name,
                Description = Description,
                RequiresSpecificBodySide = RequiresSpecificBodySide
            };
            procedureDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return procedureDocument.ToBsonDocument();
        }
    }

    public class ProcedureDocument : BaseDocument 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool RequiresSpecificBodySide { get; set; }
    }
}
