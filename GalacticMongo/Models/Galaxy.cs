using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GalacticMongo.Models
{
    // the model class for the galaxy
    public class Galaxy
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("type")]
        public string? Type { get; set; }

        [BsonElement("diameter")]
        public int Diameter { get; set; }

        [BsonElement("space_unit")]
        public string? SpaceUnit { get; set; }

        [BsonElement("black_hole")]
        public string? BlackHole { get; set; }

        [BsonElement("age")]
        public double Age { get; set; }

        [BsonElement("age_units")]
        public string? AgeUnits { get; set; }
    }
}
