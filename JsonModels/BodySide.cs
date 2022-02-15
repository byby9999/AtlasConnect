using MongoDB.Bson;
using System;
using System.Globalization;

namespace AtlasConnect.JsonModels
{
    public class BodySide : BaseJson
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public BsonDocument ToDocument() 
        {
            var document =  new BodySideDocument
            {
                _id = ObjectId.GenerateNewId(),
                Code = this.Code,
                Description = this.Description,
                CreatedBy = this.CreatedBy,
                LastUpdatedBy = this.LastUpdatedBy
            };
            document.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return document.ToBsonDocument();
        }
    }

    public class BodySideDocument : BaseDocument
    {
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
