using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class PreferenceCard : BaseJson
    {
        public int Id { get; set; }
        public string DataSourceId { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public BsonDocument ToDocument() 
        {
            var preferenceCardDocument = new PreferenceCardDocument
            {
                DataSourceId = DataSourceId,
                Active = Active,
                Code = Code,
                Description = Description
            };

            preferenceCardDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return preferenceCardDocument.ToBsonDocument();
        }
    }

    public class PreferenceCardDocument : BaseDocument
    {
        public string DataSourceId { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
       
    }
}
