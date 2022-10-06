using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
