using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Name
    {
        [BsonElement("first")]
        public string First { get; set; }
        [BsonElement("last")]
        public string Last { get; set; }
    }
}
