using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class SupplierItem : BaseJson
    {
        public string Id { get; set; }
        public string SupplierId { get; set; }
        public string ItemId { get; set; }
        public string UnitOfMeasureId { get; set; }
        public string Description { get; set; }
        public string SupplierItemCode { get; set; }
        public string SupplierItemDescription { get; set; }
        public string SupplierItemLongDescription { get; set; }
        public double UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public string DiscontinuedDate { get; set; }

        public BsonDocument ToDocument()
        {
            DateTime discontinuedDate;

            bool parsed = DateTime.TryParseExact(DiscontinuedDate, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out discontinuedDate);

            if (!parsed)
                discontinuedDate = DateTime.Now.AddYears(-1);

            var supplierItemDocument = new SupplierItemDocument
            {
                SupplierId = SupplierId,
                _partition = "61c058e5559668e69ad62a8d",
                ItemId = ItemId,
                UnitOfMeasureId = UnitOfMeasureId,
                Description = Description,
                SupplierItemCode = SupplierItemCode,
                SupplierItemDescription = SupplierItemDescription,
                SupplierItemLongDescription = SupplierItemLongDescription,
                UnitPrice = UnitPrice,
                Discontinued = Discontinued,
                DiscontinuedDate = discontinuedDate
            };
            supplierItemDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return supplierItemDocument.ToBsonDocument();
        }
    }

    public class SupplierItemDocument : BaseDocument
    {
        public string SupplierId { get; set; }
        public string ItemId { get; set; }
        public string UnitOfMeasureId { get; set; }
        public string Description { get; set; }
        public string SupplierItemCode { get; set; }
        public string SupplierItemDescription { get; set; }
        public string SupplierItemLongDescription { get; set; }
        public double UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public DateTime DiscontinuedDate { get; set; }
    }
}