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
        public BsonDocument Name = new BsonDocument();

        [BsonElement("username")]
        public string Username { get; set; }
        [BsonElement("password")]
        public BsonDocument Password = new BsonDocument();

        [BsonElement("location")]
        public Branch Location { get; set; }
        [BsonElement("role")]
        public UserRoles Role { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("number")]
        public string PhoneNumber { get; set; }


        public override string ToString()
        {
            return Name["first"].AsString;
        }


    }
}
