using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class Theatre : BaseJson
    {
        public string Id { get; set; }
        public string LocationId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string GlobalLocationNumber { get; set; }

        public BsonDocument ToDocument() 
        {
            var theatreDocument = new TheatreDocument
            {
                LocationId = LocationId,
                Code = Code, 
                Description = Description,
                GlobalLocationNumber = GlobalLocationNumber
            };
            theatreDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return theatreDocument.ToBsonDocument();
        }
    }

    public class TheatreDocument : BaseDocument
    {
        public string LocationId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string GlobalLocationNumber { get; set; }
    }
}
