using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class TheatreStaff : BaseJson
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BsonDocument ToDocument() 
        {
            var theatreStaffDoc = new TheatreStaffDocument
            {
                Code = Code,
                FirstName = FirstName, 
                LastName = LastName
            };
            theatreStaffDoc.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return theatreStaffDoc.ToBsonDocument();
        }
    }

    public class TheatreStaffDocument : BaseDocument
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
