using MongoDB.Bson;
using System;
using System.Globalization;

namespace AtlasConnect.JsonModels
{
    public class BodySite : BaseJson
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public BsonDocument ToDocument()
        {
            DateTime createdOn, lastUpdatedOn;

            bool parsed = DateTime.TryParseExact(this.CreatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out createdOn);

            if (!parsed)
                createdOn = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(this.LastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out lastUpdatedOn);

            if (!parsed)
                lastUpdatedOn = DateTime.Now.AddYears(-1);

            var document = new BodySideDocument
            {
                _id = ObjectId.GenerateNewId(),
                Code = this.Code,
                Description = this.Description,
                CreatedBy = this.CreatedBy,
                LastUpdatedBy = this.LastUpdatedBy,
                CreatedOn = createdOn,
                LastUpdatedOn = lastUpdatedOn
            };
            document.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return document.ToBsonDocument();
        }
    }

    public class BodySiteDocument : BaseDocument
    {
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
