using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CQRS.Template.Api.Domain.SeedWork
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}