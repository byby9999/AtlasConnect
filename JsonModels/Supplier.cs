using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class Supplier : BaseJson
    {
        public string Id { get; set; }
        public string SupplierApprovalExpiryDate { get; set; }
        public string SupplierApproverURL { get; set; }
        public string SupplierApproved { get; set; }
        public string DUNSNo { get; set; }

        public BsonDocument ToDocument()
        {
            DateTime supplierApprovalExpiryDate;
            bool supplierApproved = false;
            bool.TryParse(SupplierApproved, out supplierApproved);
            
            bool parsed = DateTime.TryParseExact(this.SupplierApprovalExpiryDate,
                "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out supplierApprovalExpiryDate);

            if (!parsed)
                supplierApprovalExpiryDate = DateTime.Now.AddYears(-1);

            var suppplierDocument = new SupplierDocument
            {
                SupplierApprovalExpiryDate = supplierApprovalExpiryDate,
                SupplierApproverURL = SupplierApproverURL,
                SupplierApproved = supplierApproved,
                DUNSNo = DUNSNo
            };
            suppplierDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);

            return suppplierDocument.ToBsonDocument();
        }
    }

    public class SupplierDocument : BaseDocument
    {
        public DateTime SupplierApprovalExpiryDate { get; set; }
        public string SupplierApproverURL { get; set; }
        public bool SupplierApproved { get; set; }
        public string DUNSNo { get; set; }
    }
}
