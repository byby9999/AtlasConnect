using MongoDB.Bson;
using System;
using System.Globalization;

namespace AtlasConnect.JsonModels
{
    public class ItemBarcode
    {
        public Guid Id { get; set; }
        public string ItemId { get; set; }
        public string UDI { get; set; }
        public string RawData { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string LastUpdatedOn { get; set; }

        public BsonDocument ToDocument() 
        {
            DateTime createdOn, lastUpdatedOn;

            bool parsed = DateTime.TryParseExact(this.CreatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out createdOn);

            if (!parsed)
                createdOn = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(this.LastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out lastUpdatedOn);

            if (!parsed)
                lastUpdatedOn = DateTime.Now.AddYears(-1);

            var itemDocument = new ItemBarcodeDocument
            {
                _id = ObjectId.GenerateNewId(),
                _partition = "61c058e5559668e69ad62a8d",
                ItemId = ItemId,
                UDI = UDI,
                RawData = RawData,
                CreatedBy = CreatedBy,
                LastUpdatedBy = LastUpdatedBy,
                CreatedOn = createdOn,
                LastUpdatedOn = lastUpdatedOn
            };

            itemDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return itemDocument.ToBsonDocument();
        }
    }

    public class ItemBarcodeDocument : BaseDocument
    {
        public string ItemId { get; set; }
        public string UDI { get; set; }
        public string RawData { get; set; }
    }
}
