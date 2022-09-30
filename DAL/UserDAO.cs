using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DAL
{
    public class UserDAO : DAO
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            var collection = base.ReturnCollection("Users");
            var documents = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument document in documents)
            {
                User user = BsonSerializer.Deserialize<User>(document);
                users.Add(user);
            }

            return users;
        }

    }
}
