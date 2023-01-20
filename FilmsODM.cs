using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebshopLabb
{
    internal class FilmsODM
    {
        [BsonId]

        public ObjectId id { get; set; }
        [BsonElement("Title")]

        public string? Title { get; set; }
        [BsonElement("Director")]

        public string? Director { get; set; }
        [BsonElement("Genre")]

        public string Genre { get; set; }
        [BsonElement("Price")]

        public int Price { get; set; }
    }
}
