using MongoDB.Bson;

namespace AtlasConnect.JsonModels
{
    public class PreferenceCardItem : BaseJson
    {
        public int Id { get; set; }
        public int PreferenceCardId { get; set; }
        public string ItemId { get; set; }
        public string UnitOfMeasureId { get; set; }
        public bool Active { get; set; }
        public int Quantity { get; set; }

        public BsonDocument ToDocument() 
        {
            var preferenceCardItemDocument = new PreferenceCardItemDocument();

            preferenceCardItemDocument.PreferenceCardId = this.PreferenceCardId;
            preferenceCardItemDocument.ItemId = this.ItemId;
            preferenceCardItemDocument.UnitOfMeasureId = this.UnitOfMeasureId;
            preferenceCardItemDocument.Active = this.Active;
            preferenceCardItemDocument.Quantity = this.Quantity;

            preferenceCardItemDocument.SetCreateLastUpdate(this.CreatedOn, this.LastUpdatedOn, this.Id.ToString());

            return preferenceCardItemDocument.ToBsonDocument();
        }
    }

    public class PreferenceCardItemDocument : BaseDocument 
    {
        public int PreferenceCardId { get; set; }
        public string ItemId { get; set; }
        public string UnitOfMeasureId { get; set; }
        public bool Active { get; set; }
        public int Quantity { get; set; }
    }
}
