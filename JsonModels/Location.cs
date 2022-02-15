using MongoDB.Bson;
using System;
using System.Globalization;

namespace AtlasConnect.JsonModels
{
    public class Location : BaseJson
    { 
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string GlobalLocationNumber { get; set; }

        public string Description { get; set; }
        public bool IsStore { get; set; }
        public bool IsQuarantineLocation { get; set; }
        public string OrganisationSiteId { get; set; }

        public BsonDocument ToDocument() 
        {
            
            var locationDocument = new LocationDocument
            {
                _id = ObjectId.GenerateNewId(),
                Code = Code,
                GlobalLocationNumber = GlobalLocationNumber,
                Description = Description,
                IsStore = IsStore,
                IsQuarantineLocation = IsQuarantineLocation,
                OrganisationSiteId = OrganisationSiteId,
                CreatedBy = CreatedBy,
                LastUpdatedBy = LastUpdatedBy
            };
            locationDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());
            
            return locationDocument.ToBsonDocument();
        }
    }

    public class LocationDocument : BaseDocument
    {
        public string Code { get; set; }
        public string GlobalLocationNumber { get; set; }

        public string Description { get; set; }
        public bool IsStore { get; set; }
        public bool IsQuarantineLocation { get; set; }
        public string OrganisationSiteId { get; set; }
    }
}
