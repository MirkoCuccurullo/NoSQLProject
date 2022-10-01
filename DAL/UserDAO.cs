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

            //getting user collection
            var collection = base.ReturnCollection("Users");

            //getting all documents in the collection 
            var documents = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument document in documents)
            {
                //deserealizing a Bdon document in a User object
                User user = BsonSerializer.Deserialize<User>(document);
                users.Add(user);
            }

            return users;
        }

    }
}
