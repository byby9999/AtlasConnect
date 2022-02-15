using MongoDB.Bson;

namespace AtlasConnect.JsonModels
{
    public class Patient
    {
        public string Id { get; set; }
        public string PatientIdentificationNumber { get; set; }
        public string GlobalServiceRelationNumber { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedOn { get; set; }

        public BsonDocument ToDocument() 
        {
            var patientDoc = new PatientDocument
            {
                PatientIdentificationNumber = PatientIdentificationNumber,
                GlobalServiceRelationNumber = GlobalServiceRelationNumber,
                CreatedBy = CreatedBy,
                LastUpdatedBy = LastUpdatedBy
            };

            patientDoc.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, Id);

            return patientDoc.ToBsonDocument();
        }
    }

    public class PatientDocument : BaseDocument
    {
        public string PatientIdentificationNumber { get; set; }
        public string GlobalServiceRelationNumber { get; set; }
    }

}
