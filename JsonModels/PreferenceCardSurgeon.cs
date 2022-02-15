using MongoDB.Bson;

namespace AtlasConnect.JsonModels
{
    public class PreferenceCardSurgeon : BaseJson
    {
        public int Id { get; set; }
        public int PreferenceCardId { get; set; }
        public string SurgeonId { get; set; }
        public bool Active { get; set; }

        public BsonDocument ToDocument() 
        {
            var prefCardSurgeonDocument = new PreferenceCardSurgeonDocument
            {
                PreferenceCardId = PreferenceCardId,
                SurgeonId = SurgeonId,
                Active = Active
            };
            prefCardSurgeonDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());
            return prefCardSurgeonDocument.ToBsonDocument();
        }
    }

    public class PreferenceCardSurgeonDocument : BaseDocument
    {
        public int PreferenceCardId { get; set; }
        public string SurgeonId { get; set; }
        public bool Active { get; set; }
    }
}
