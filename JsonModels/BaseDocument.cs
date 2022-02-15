using MongoDB.Bson;
using System;
using System.Globalization;

namespace AtlasConnect.JsonModels
{
    public class BaseDocument
    {
        public ObjectId _id { get; set; }

        public string _partition { get; set; }
        public string InternId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; }

        public void SetCreateLastUpdate(string createdOn, string lastUpdatedOn, string id) 
        {
            _id = ObjectId.GenerateNewId();
            InternId = id;

            DateTime createdOnDate, lastUpdatedOnDate;

            bool parsed = DateTime.TryParseExact(createdOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out createdOnDate);

            if (!parsed)
                createdOnDate = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(lastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out lastUpdatedOnDate);

            if (!parsed)
                lastUpdatedOnDate = DateTime.Now.AddYears(-1);

            this.CreatedOn = createdOnDate;
            this.LastUpdatedOn = lastUpdatedOnDate;

            _partition = Configurations.PartitionDefault;
        }
    }
}
