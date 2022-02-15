using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class SurgeryItemStatusReason : BaseJson
    {
        public string Id { get; set; }
        public int SurgeryItemStatus { get; set; }
        public string Reason { get; set; }
       

        public BsonDocument ToDocument()
        {
            var itemDocument = new SurgeryItemStatusReasonDocument
            {
                SurgeryItemStatus = SurgeryItemStatus,
                Reason = Reason
            };
            itemDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return itemDocument.ToBsonDocument();
        }
    }

    public class SurgeryItemStatusReasonDocument : BaseDocument
    {
        public int SurgeryItemStatus { get; set; }
        public string Reason { get; set; }
    }
}
