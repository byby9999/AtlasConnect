using MongoDB.Bson;
using System;
using System.Globalization;

namespace AtlasConnect.JsonModels
{
    public class Item : BaseJson
    {
        public Guid Id { get; set; }
        public string SupplierItemId { get; set; }
        public string ItemCode { get; set; }
        public string SupplierItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string UOMDescription { get; set; }
        public int RatioToBase { get; set; }
        public bool IsImplant { get; set; }
        public double UnitPrice { get; set; }

        public bool RequiresSerialNumber { get; set; }
        public bool RequiresLotNumber { get; set; }
        public bool RequiresExpiryDate { get; set; }

        public string ItemCategoryId { get; set; }
        public string SupplierItemLastUpdatedOn { get; set; }
        public string TemperatureTypeId { get; set; }
        public string AcceptableTemperatureRange { get; set; }
        public string BodySiteId { get; set; }
        public string BodySideId { get; set; }
        public string SupplierId { get; set; }
        public string ItemStatusId { get; set; }
        public double AcceptableTemperatureFrom { get; set; }
        public double AcceptableTemperatureTo { get; set; }
        public bool AutoReceipt { get; set; }

        public BsonDocument ToDocument()
        {
            DateTime supplierItemLastUpdatedOn;

            bool parsed = DateTime.TryParseExact(this.SupplierItemLastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out supplierItemLastUpdatedOn);

            if (!parsed)
                supplierItemLastUpdatedOn = DateTime.Now.AddYears(-1);

            var itemDocument = new ItemDocument
            {
                _id = ObjectId.GenerateNewId(),
                _partition = "61c058e5559668e69ad62a8d",
                SupplierItemId = this.SupplierItemId,
                ItemCode = this.ItemCode,
                SupplierItemCode = this.SupplierItemCode,
                ItemDescription = this.ItemDescription,
                UOMDescription = this.UOMDescription,
                RatioToBase = this.RatioToBase,
                IsImplant = this.IsImplant,
                UnitPrice = this.UnitPrice,
                RequiresSerialNumber = this.RequiresSerialNumber,
                RequiresLotNumber = this.RequiresLotNumber,
                RequiresExpiryDate = this.RequiresExpiryDate,
                ItemCategoryId = this.ItemCategoryId,
                TemperatureTypeId = this.TemperatureTypeId,
                AcceptableTemperatureRange = this.AcceptableTemperatureRange,
                BodySiteId = this.BodySiteId,
                BodySideId = this.BodySideId,
                SupplierId = this.SupplierId,
                ItemStatusId = this.ItemStatusId,
                AcceptableTemperatureFrom = this.AcceptableTemperatureFrom,
                AcceptableTemperatureTo = this.AcceptableTemperatureTo,
                AutoReceipt = this.AutoReceipt,
                CreatedBy = this.CreatedBy,
                LastUpdatedBy = this.LastUpdatedBy,
                SupplierItemLastUpdatedOn = supplierItemLastUpdatedOn
            };

            itemDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return itemDocument.ToBsonDocument();
        }
    }

    public class ItemDocument : BaseDocument
    {
        public string SupplierItemId { get; set; }
        public string ItemCode { get; set; }
        public string SupplierItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string UOMDescription { get; set; }
        public int RatioToBase { get; set; }
        public bool IsImplant { get; set; }
        public double UnitPrice { get; set; }

        public bool RequiresSerialNumber { get; set; }
        public bool RequiresLotNumber { get; set; }
        public bool RequiresExpiryDate { get; set; }

        public string ItemCategoryId { get; set; }
        public DateTime SupplierItemLastUpdatedOn { get; set; }
        public string TemperatureTypeId { get; set; }
        public string AcceptableTemperatureRange { get; set; }
        public string BodySiteId { get; set; }
        public string BodySideId { get; set; }
        public string SupplierId { get; set; }
        public string ItemStatusId { get; set; }
        public double AcceptableTemperatureFrom { get; set; }
        public double AcceptableTemperatureTo { get; set; }
        public bool AutoReceipt { get; set; }
    }
}

