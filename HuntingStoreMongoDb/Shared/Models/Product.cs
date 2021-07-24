using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HuntingStoreMongoDb.Shared.Models
{
    public class Product
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        [BsonElement("name")]
        public string Name { get; set; }


        private decimal price;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        [BsonElement("price")]
        public decimal Price
        {
            get => price;
            set
            {
                if (price < 0)
                    throw new ArgumentException();
                else
                    price = value;
            }
        }

        [Required(ErrorMessage = "Please enter a description")]
        [BsonElement("description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        [BsonElement("category")]
        public string Category { get; set; }
    }
}
