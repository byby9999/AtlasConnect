using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class Surgery : BaseJson
    {
        public double TotalCost { get; set; }
        public double TotalCostIncludingVat { get; set; }
        public string SurgeryId { get; set; }
        public string ProcedureId { get; set; }
        public string SurgeonId { get; set; }
        public string TheatreId { get; set; }
        public string Reference { get; set; }
        public string ProcedureCode { get; set; }
        public string ProcedureName { get; set; }
        public string Theatre { get; set; }
        public string Surgeon { get; set; }
        public string SurgeonWithCode { get; set; }
        public string PatientIdentificationNumber { get; set; }
        public int Lines { get; set; }
        public double SurgeryItemTotalCost { get; set; }
        public double SurgeryStaffTotalCost { get; set; }
        public double TheatreTotalCost { get; set; }
        public string Duration { get; set; }
        public double SurgeryItemTotalCostIncludingVat { get; set; }
        public string ModuleId { get; set; }
        public string StartedOn { get; set; }
        public string SecondaryProcedures { get; set; }
        public string Note { get; set; }
        public string BodySide { get; set; }

        public BsonDocument ToDocument() 
        {
            DateTime startedOn;

            bool parsed = DateTime.TryParseExact(StartedOn, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out startedOn);

            if (!parsed)
                startedOn = DateTime.Now.AddYears(-1);

            var surgeryDocument = new SurgeryDocument
            {
                TotalCost= TotalCost,
                TotalCostIncludingVat = TotalCostIncludingVat,
                SurgeryId = SurgeryId,
                ProcedureId = ProcedureId,
                SurgeonId= SurgeonId, 
                TheatreId = TheatreId,
                Reference = Reference,
                ProcedureCode = ProcedureCode,
                ProcedureName = ProcedureName,
                Theatre = Theatre,
                Surgeon = Surgeon,
                SurgeonWithCode = SurgeonWithCode,
                PatientIdentificationNumber = PatientIdentificationNumber,
                Lines = Lines,
                SurgeryItemTotalCost = SurgeryItemTotalCost,
                SurgeryStaffTotalCost = SurgeryStaffTotalCost,
                TheatreTotalCost = TheatreTotalCost,
                Duration = Duration,
                SurgeryItemTotalCostIncludingVat = SurgeryItemTotalCostIncludingVat,
                ModuleId = ModuleId,
                StartedOn = startedOn,
                SecondaryProcedures = SecondaryProcedures,
                Note = Note,
                BodySide = BodySide
            };
            surgeryDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.SurgeryId);
            return surgeryDocument.ToBsonDocument();
        }
    }

    public class SurgeryDocument : BaseDocument
    {
        public double TotalCost { get; set; }
        public double TotalCostIncludingVat { get; set; }
        public string SurgeryId { get; set; }
        public string ProcedureId { get; set; }
        public string SurgeonId { get; set; }
        public string TheatreId { get; set; }
        public string Reference { get; set; }
        public string ProcedureCode { get; set; }
        public string ProcedureName { get; set; }
        public string Theatre { get; set; }
        public string Surgeon { get; set; }
        public string SurgeonWithCode { get; set; }
        public string PatientIdentificationNumber { get; set; }
        public int Lines { get; set; }
        public double SurgeryItemTotalCost { get; set; }
        public double SurgeryStaffTotalCost { get; set; }
        public double TheatreTotalCost { get; set; }
        public string Duration { get; set; }
        public double SurgeryItemTotalCostIncludingVat { get; set; }
        public string ModuleId { get; set; }
        public DateTime StartedOn { get; set; }
        public string SecondaryProcedures { get; set; }
        public string Note { get; set; }
        public string BodySide { get; set; }
    }
}
