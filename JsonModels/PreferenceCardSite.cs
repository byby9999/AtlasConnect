using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class PreferenceCardSite : BaseJson
    {
        public int Id { get; set; }
        public int PreferenceCardId { get; set; }
        public string OrganisationSiteId { get; set; }
        public bool Active { get; set; }

        public BsonDocument ToDocument() 
        {
            var prefCardSiteDocument = new PreferenceCardSiteDocument
            {
                PreferenceCardId = PreferenceCardId,
                OrganisationSiteId = OrganisationSiteId,
                Active = Active
            };
            prefCardSiteDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return prefCardSiteDocument.ToBsonDocument();
        }
    }

    public class PreferenceCardSiteDocument : BaseDocument 
    {
        public int PreferenceCardId { get; set; }
        public string OrganisationSiteId { get; set; }
        public bool Active { get; set; }
    }
}
