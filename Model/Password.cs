using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Password
    {
        [BsonElement("hash")]
        public string Hash { get; set; }
        [BsonElement("salt")]
        public string Salt { get; set; }

        [BsonElement("question")]
        public string Question { get; set; }
        [BsonElement("answer")]
        public string Answer { get; set; }
    }
}
