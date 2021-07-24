using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace HuntingStoreMongoDb.Shared.Models
{
    public class CartLine
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("quantity")]
        public int Quantity { get; set; }
        [BsonElement("product_id")]
        public string ProductId { get; set; }
        [BsonElement("order_id")]
        public string OrderId { get; set; }
    }
}
