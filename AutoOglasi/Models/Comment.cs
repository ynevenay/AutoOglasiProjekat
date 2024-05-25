using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace AutoOglasi.Models
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRequired]
        public string UserId { get; set; }

        [BsonRequired]
        public string Text { get; set; }

        [BsonRequired]
        public DateTime CreatedAt { get; set; }
        //Da bi mogla da prikazem koji korisnik je postavio komentar
        [BsonIgnore]
        public ApplicationUser User { get; set; }
    }
}
