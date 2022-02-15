using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class SurgeryItem : BaseJson
    {
        public double Level1NettCost { get; set; }
        public double Level1Vat { get; set; }
        public double Level1GrossCost { get; set; }
        public string ImplantSurgeonFullName { get; set; }
        public string ImplantStaffFullName { get; set; }
        public string SurgeryId { get; set; }
        public string Supplier { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public double UnitPrice { get; set; }
        public double VatRate { get; set; }
        public string UnitOfMeasure { get; set; }
        public int RatioToBase { get; set; }
        public double NettCost { get; set; }
        public double UnitCost { get; set; }
        public int Quantity { get; set; }
        public double Vat { get; set; }
        public double GrossCost { get; set; }
        public string Level1Group { get; set; }
        public string BranchPointCode { get; set; }
        public string CostCenterCode { get; set; }
        public string LotNumber { get; set; }
        public string SerialNumber { get; set; }
        public string ExpiryDateFull { get; set; }
        public string BodySide { get; set; }
        public string BrandName { get; set; }
        public string ManufacturerName { get; set; }
        public string ImplantDocumentTime { get; set; }
        public string ImplantTime { get; set; }
        public string SurgeonTitle { get; set; }
        public string SurgeonFirstName { get; set; }
        public string SurgeonLastName { get; set; }
        public string StaffTitle { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public string ImplantNotes { get; set; }
        public string ItemCategoryId { get; set; }
        public string Laterality { get; set; }

        public BsonDocument ToDocument() 
        {
            DateTime implantDocumentTime, implantTime;
            bool parsed = DateTime.TryParseExact(ImplantDocumentTime, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out implantDocumentTime);

            if (!parsed)
                implantDocumentTime = DateTime.Now.AddYears(-1);

            parsed = DateTime.TryParseExact(ImplantTime, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out implantTime);

            if (!parsed)
                implantTime = DateTime.Now.AddYears(-1);

            var surgeryItemDocument = new SurgeryItemDocument
            {
                Level1NettCost = Level1NettCost,
                Level1Vat = Level1Vat,
                Level1GrossCost = Level1GrossCost,
                ImplantSurgeonFullName = ImplantSurgeonFullName,
                ImplantStaffFullName = ImplantStaffFullName,
                SurgeryId = SurgeryId,
                Supplier = Supplier,
                ItemCode = ItemCode,
                ItemDescription = ItemDescription,
                UnitPrice = UnitPrice,
                VatRate = VatRate,
                UnitOfMeasure = UnitOfMeasure,
                RatioToBase = RatioToBase,
                NettCost = NettCost, 
                UnitCost = UnitCost,
                Quantity = Quantity,
                Vat = Vat,
                GrossCost = GrossCost,
                Level1Group = Level1Group,
                BranchPointCode = BranchPointCode,
                CostCenterCode = CostCenterCode,
                LotNumber = LotNumber,
                SerialNumber = SerialNumber,
                ExpiryDateFull = ExpiryDateFull,
                BodySide = BodySide,
                BrandName = BrandName, 
                ManufacturerName = ManufacturerName,
                ImplantDocumentTime = implantDocumentTime,
                ImplantTime = implantTime,
                SurgeonTitle = SurgeonTitle,
                SurgeonFirstName = SurgeonFirstName,
                SurgeonLastName = SurgeonLastName,
                StaffTitle = StaffTitle, 
                StaffFirstName = StaffFirstName,
                StaffLastName = StaffLastName,
                ImplantNotes = ImplantNotes,
                ItemCategoryId = ItemCategoryId,
                Laterality = Laterality
            };
            surgeryItemDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.SurgeryId);

            return surgeryItemDocument.ToBsonDocument();
        }
    }

    public class SurgeryItemDocument : BaseDocument
    {
        public double Level1NettCost { get; set; }
        public double Level1Vat { get; set; }
        public double Level1GrossCost { get; set; }
        public string ImplantSurgeonFullName { get; set; }
        public string ImplantStaffFullName { get; set; }
        public string SurgeryId { get; set; }
        public string Supplier { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public double UnitPrice { get; set; }
        public double VatRate { get; set; }
        public string UnitOfMeasure { get; set; }
        public int RatioToBase { get; set; }
        public double NettCost { get; set; }
        public double UnitCost { get; set; }
        public int Quantity { get; set; }
        public double Vat { get; set; }
        public double GrossCost { get; set; }
        public string Level1Group { get; set; }
        public string BranchPointCode { get; set; }
        public string CostCenterCode { get; set; }
        public string LotNumber { get; set; }
        public string SerialNumber { get; set; }
        public string ExpiryDateFull { get; set; }
        public string BodySide { get; set; }
        public string BrandName { get; set; }
        public string ManufacturerName { get; set; }
        public DateTime ImplantDocumentTime { get; set; }
        public DateTime ImplantTime { get; set; }
        public string SurgeonTitle { get; set; }
        public string SurgeonFirstName { get; set; }
        public string SurgeonLastName { get; set; }
        public string StaffTitle { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public string ImplantNotes { get; set; }
        public string ItemCategoryId { get; set; }
        public string Laterality { get; set; }
    }
}
