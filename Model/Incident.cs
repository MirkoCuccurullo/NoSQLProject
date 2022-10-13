using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Incident
    {
        [BsonElement("subject")]
        public string Subject { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }

    }
}
