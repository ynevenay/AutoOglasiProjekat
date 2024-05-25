using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AutoOglasi.Models
{
    public class Car
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRequired]
        public string UserId { get; set; }

        [BsonElement("Brand")]
        [Required(ErrorMessage = "Proizvodjac je obavezan")]
        public string Brand { get; set; }

        [BsonElement("Model")]
        [Required(ErrorMessage = "Model je obavezan")]
        public string Model { get; set; }

        [BsonElement("Year")]
        [Required(ErrorMessage = "Godiste je obavezno")]
        public int Year { get; set; }

        [BsonElement("Price")]
        [Required(ErrorMessage = "Cena je obavezna")]
        public decimal Price { get; set; }

        [BsonElement("Images")]
        public List<BsonBinaryData> Images { get; set; } = new List<BsonBinaryData>();

        [BsonElement("Description")]
        [Required(ErrorMessage = "Opis vozila je obavezan")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<Comment> Comments { get; set; } // lista komentara za dati auto

        public Car()
        {
            Comments = new List<Comment>(); // inicijalizacija liste komenatara
        }
        //Da bi mogla da prikazem koji korisnik je postavio oglas
        public ApplicationUser User { get; set; }

    }
}

