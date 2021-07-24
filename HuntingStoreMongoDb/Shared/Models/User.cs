using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace HuntingStoreMongoDb.Shared.Models
{
    public class User
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("user_name")]
        public string Username { get; set; }

        [BsonElement("password_hash")]
        public byte[] PasswordHash { get; set; }

        [BsonElement("password_salt")]
        public byte[] PasswordSalt { get; set; }
    }
}
