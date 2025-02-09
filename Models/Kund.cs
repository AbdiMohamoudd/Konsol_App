using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Kund
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }

        public List<string> KöptaBöcker { get; set; } = new List<string>(); 
    }
}
