using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class Surgeon : BaseJson
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }

        public BsonDocument ToDocument()
        {
            var surgeonDocument = new SurgeonDocument
            {
                Code = Code,
                Title = Title,
                FirstName = FirstName,
                LastName = LastName,
                Active = Active
            };
            surgeonDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return surgeonDocument.ToBsonDocument();
        }

    }

    public class SurgeonDocument : BaseDocument
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
    }
}
