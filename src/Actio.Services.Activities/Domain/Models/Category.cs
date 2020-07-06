using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Actio.Services.Activities.Domain.Models
{
    [BsonIgnoreExtraElements]
    public class Category
    {
        public Guid Id { get; protected set; }
        [BsonElement("name")]
        public string Name { get; protected set; }  

        protected Category()
        {
        }

        public Category(string name)
        {
            Id = Guid.NewGuid();
            Name = name.ToLowerInvariant();
        }      
    }
}