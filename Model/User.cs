using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        [BsonId]
        public BsonObjectId Id { get; set; }
        [BsonElement("name")]
        public string[] name { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }
        [BsonElement("password")]
        public string[] Password { get; set; }

        [BsonElement("location")]
        public string Location { get; set; }
        [BsonElement("role")]
        public string Role { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }


        public override string ToString()
        {
            return name[0];
        }


    }
}
