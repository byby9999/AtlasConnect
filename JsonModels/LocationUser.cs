using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class LocationUser : BaseJson
    {
        public Guid Id { get; set; }
        public string LocationId { get; set; }
        public string UserId { get; set; }
        public bool Active { get; set; }

        public BsonDocument ToDocument()
        {
            DateTime createdOn  = DateTime.Now.AddYears(-1);
            DateTime lastUpdatedOn = DateTime.Now.AddYears(-1);

            DateTime.TryParseExact(this.CreatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out createdOn);
            DateTime.TryParseExact(this.LastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out lastUpdatedOn);

            var locUserDocument = new LocationUserDocument
            {
                _id = ObjectId.GenerateNewId(),
                LocationId = LocationId,
                UserId = UserId,
                Active = Active,
                CreatedBy = CreatedBy,
                LastUpdatedBy = LastUpdatedBy
            };

            locUserDocument.CreatedOn = createdOn;
            locUserDocument.LastUpdatedOn = lastUpdatedOn;
            locUserDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());
            
            return locUserDocument.ToBsonDocument();
        }
    }

    public class LocationUserDocument : BaseDocument
    {
        public string LocationId { get; set; }
        public string UserId { get; set; }
        public bool Active { get; set; }
    }
}
