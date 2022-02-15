using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class OrganisationSiteUser : BaseJson
    { 
        public Guid Id { get; set; }
        public string OrganisationSiteId { get; set; }
        public string UserId { get; set; }
        public bool Active { get; set; }

        public BsonDocument ToDocument() 
        {
            DateTime createdOn, lastUpdatedOn;

            bool parsed = DateTime.TryParseExact(this.CreatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out createdOn);

            if (!parsed)
                createdOn = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(this.LastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out lastUpdatedOn);

            if (!parsed)
                lastUpdatedOn = DateTime.Now.AddYears(-1);

            var doc = new OrganisationSiteUserDocument
            {
                _id = ObjectId.GenerateNewId(),
                InternId = Id.ToString(),
                OrganisationSiteId = OrganisationSiteId,
                UserId = UserId,
                Active = Active,
                CreatedBy = CreatedBy,
                LastUpdatedBy = LastUpdatedBy
            };
            doc.CreatedOn = createdOn;
            doc.LastUpdatedOn = lastUpdatedOn;

            doc.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return doc.ToBsonDocument();
        }
    }

    public class OrganisationSiteUserDocument : BaseDocument
    {
        public string OrganisationSiteId { get; set; }
        public string UserId { get; set; }
        public bool Active { get; set; }
    }
}
