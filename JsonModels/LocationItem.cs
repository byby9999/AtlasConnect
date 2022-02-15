using MongoDB.Bson;
using System;
using System.Globalization;

namespace AtlasConnect.JsonModels
{
    public class LocationItem : BaseJson
    {
        public Guid Id { get; set; }
        public string LocationId { get; set; }
        public string ItemId { get; set; }
        public string ItemSublocationCode { get; set; }
        public string ReplenishFromLocationItemId { get; set; }
        public string ReplenishFromSupplierItemId { get; set; }
        public string UOMDescription { get; set; }
        public int RatioToBase { get; set; }
        public int ReorderLevel { get; set; }
        public int ReorderQty { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public bool IsKanBan { get; set; }
        public int KanBanLevel { get; set; }
        public int StockLevelQuantity { get; set; }
        public string RequiresSerialNumber { get; set; }
        public string RequiresLotNumber { get; set; }
        public string RequiresExpiryDate { get; set; }
        public int QuantityAwaitingReleaseInBaseUnits { get; set; }
        public int QuantityOrderedInBaseUnits { get; set; }
        public int QuantityAllocatedInBaseUnits { get; set; }
        public int QuantityReturningInBaseUnits { get; set; }
        public bool IsRequisitionAllowed { get; set; }
        public bool IsReplenishedFromSupplier { get; set; }
        public bool IsReplenishLocationActive { get; set; }
        public bool Deactivated { get; set; }
        public bool CanBeQuarantined { get; set; }
        public int ItemOrder { get; set; }
        public string LocationProfileItemLastUpdatedOn { get; set; }
        public string CellContentLastUpdatedOn { get; set; }
        public string LpiCalculationLastUpdatedOn { get; set; }
        public string TombstoneOperationOn { get; set; }

        public BsonDocument ToDocument() 
        {
            DateTime tombstoneOperationOn, lpiCalculationLastUpdatedOn, locationProfileItemLastUpdatedOn, cellContentLastUpdatedOn;

            bool parsed = DateTime.TryParseExact(this.TombstoneOperationOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out tombstoneOperationOn);

            if (!parsed)
                tombstoneOperationOn = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(this.LpiCalculationLastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out lpiCalculationLastUpdatedOn);

            if (!parsed)
                lpiCalculationLastUpdatedOn = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(this.LocationProfileItemLastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out locationProfileItemLastUpdatedOn);

            if (!parsed)
                locationProfileItemLastUpdatedOn = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(this.CellContentLastUpdatedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out cellContentLastUpdatedOn);

            if (!parsed)
                cellContentLastUpdatedOn = DateTime.Now.AddYears(-1);

            bool requiresSerialNumber = false, requiresLotNumber = false, requiresExpiryDate = false;

            bool.TryParse(RequiresSerialNumber, out requiresSerialNumber);
            bool.TryParse(RequiresLotNumber, out requiresLotNumber);
            bool.TryParse(RequiresExpiryDate, out requiresExpiryDate);

            var locationItemDocument = new LocationItemDocument()
            {
                _id = ObjectId.GenerateNewId(),
                LocationId = LocationId,
                ItemId = ItemId,
                ItemSublocationCode = ItemSublocationCode,
                ReplenishFromLocationItemId = ReplenishFromLocationItemId,
                ReplenishFromSupplierItemId = ReplenishFromSupplierItemId,
                UOMDescription = UOMDescription,
                RatioToBase = RatioToBase,
                ReorderLevel = ReorderLevel,
                ReorderQty = ReorderQty,
                MinLevel = MinLevel,
                MaxLevel = MaxLevel,
                IsKanBan = IsKanBan,
                KanBanLevel = KanBanLevel,
                StockLevelQuantity = StockLevelQuantity,
                RequiresSerialNumber = requiresSerialNumber,
                RequiresLotNumber = requiresLotNumber,
                RequiresExpiryDate = requiresExpiryDate,
                QuantityAllocatedInBaseUnits = QuantityAllocatedInBaseUnits,
                QuantityAwaitingReleaseInBaseUnits = QuantityAwaitingReleaseInBaseUnits,
                QuantityOrderedInBaseUnits = QuantityOrderedInBaseUnits,
                QuantityReturningInBaseUnits = QuantityReturningInBaseUnits,
                IsReplenishedFromSupplier = IsReplenishedFromSupplier,
                IsReplenishLocationActive = IsReplenishLocationActive,
                IsRequisitionAllowed = IsRequisitionAllowed,
                Deactivated = Deactivated,
                CanBeQuarantined = CanBeQuarantined,
                ItemOrder = ItemOrder,
                CreatedBy = CreatedBy,
                LastUpdatedBy = LastUpdatedBy
            };

            locationItemDocument.TombstoneOperationOn = tombstoneOperationOn;
            locationItemDocument.LpiCalculationLastUpdatedOn = lpiCalculationLastUpdatedOn;
            locationItemDocument.LocationProfileItemLastUpdatedOn = locationProfileItemLastUpdatedOn;
            locationItemDocument.CellContentLastUpdatedOn = cellContentLastUpdatedOn;

            locationItemDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return locationItemDocument.ToBsonDocument();
        }

    }

    public class LocationItemDocument : BaseDocument
    {
        public string LocationId { get; set; }
        public string ItemId { get; set; }
        public string ItemSublocationCode { get; set; }
        public string ReplenishFromLocationItemId { get; set; }
        public string ReplenishFromSupplierItemId { get; set; }
        public string UOMDescription { get; set; }
        public int RatioToBase { get; set; }
        public int ReorderLevel { get; set; }
        public int ReorderQty { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public bool IsKanBan { get; set; }
        public int KanBanLevel { get; set; }
        public int StockLevelQuantity { get; set; }
        public bool RequiresSerialNumber { get; set; }
        public bool RequiresLotNumber { get; set; }
        public bool RequiresExpiryDate { get; set; }
        public int QuantityAwaitingReleaseInBaseUnits { get; set; }
        public int QuantityOrderedInBaseUnits { get; set; }
        public int QuantityAllocatedInBaseUnits { get; set; }
        public int QuantityReturningInBaseUnits { get; set; }
        public bool IsRequisitionAllowed { get; set; }
        public bool IsReplenishedFromSupplier { get; set; }
        public bool IsReplenishLocationActive { get; set; }
        public bool Deactivated { get; set; }
        public bool CanBeQuarantined { get; set; }
        public int ItemOrder { get; set; }
        public DateTime LocationProfileItemLastUpdatedOn { get; set; }
        public DateTime CellContentLastUpdatedOn { get; set; }
        public DateTime LpiCalculationLastUpdatedOn { get; set; }
        public DateTime TombstoneOperationOn { get; set; }
    }
}
