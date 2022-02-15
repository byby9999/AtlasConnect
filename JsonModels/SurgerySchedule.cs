using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class SurgerySchedule : BaseJson
    {
        public string Id { get; set; }
        public string TheatreId { get; set; }
        public string PatientId { get; set; }
        public string SurgeonId { get; set; }
        public string ProcedureId { get; set; }
        public string PreferenceCardId { get; set; }
        public string SurgeryDate { get; set; }
        public string HasMultipleSurgeons { get; set; }
        public string Laterality { get; set; }
        public int Status { get; set; }
        public string SurgeryScheduleCode { get; set; }

        public BsonDocument ToDocument() 
        {
            DateTime surgeryDate;
            bool hasMultipleSurgeons = false;
            int preferenceCardId = 1;

            bool parsed = DateTime.TryParseExact(SurgeryDate, "yyyy-MM-ddTHH:mm:ss.fffK", CultureInfo.InvariantCulture, DateTimeStyles.None, out surgeryDate);

            if (!parsed)
                surgeryDate = DateTime.Now.AddYears(-1);

            bool.TryParse(HasMultipleSurgeons, out hasMultipleSurgeons);

            int.TryParse(PreferenceCardId, out preferenceCardId);

            var surgeryScheduleDocument = new SurgeryScheduleDocument
            {
                TheatreId = TheatreId,
                PatientId = PatientId,
                SurgeonId = SurgeonId,
                ProcedureId = ProcedureId,
                PreferenceCardId = preferenceCardId,
                SurgeryDate = surgeryDate,
                HasMultipleSurgeons = hasMultipleSurgeons,
                Laterality = Laterality,
                Status = Status,
                SurgeryScheduleCode = SurgeryScheduleCode
            };
            surgeryScheduleDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id);
            return surgeryScheduleDocument.ToBsonDocument();
        }
    }
    public class SurgeryScheduleDocument : BaseDocument
    {
        public string TheatreId { get; set; }
        public string PatientId { get; set; }
        public string SurgeonId { get; set; }
        public string ProcedureId { get; set; }
        public int PreferenceCardId { get; set; }
        public DateTime SurgeryDate { get; set; }
        public bool HasMultipleSurgeons { get; set; }
        public string Laterality { get; set; }
        public int Status { get; set; }
        public string SurgeryScheduleCode { get; set; }
    }
}
