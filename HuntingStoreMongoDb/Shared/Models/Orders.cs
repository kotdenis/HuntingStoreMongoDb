using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace HuntingStoreMongoDb.Shared.Models
{
    public class Orders
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("address_line1")]
        public string AddressLine1 { get; set; }
        [BsonElement("address_line2")]
        public string AddressLine2 { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("state")]
        public string State { get; set; }

        [BsonElement("zip")]
        public string Zip { get; set; }
        [BsonElement("gift_wrap")]
        public bool GiftWrap { get; set; }
        [BsonElement("shipped")]
        public bool Shipped { get; set; }
        [BsonElement("country")]
        public string Country { get; set; }
    }
}
