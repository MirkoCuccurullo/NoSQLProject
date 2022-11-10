using System;
using System.Collections.Generic;
using System.Linq;
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

            try
            {

                //getting user collection
                var collection = base.ReturnCollection(Database.noSqlProject, Collection.Users);

                //getting all documents in the collection 
                var documents = collection.Find(new BsonDocument()).ToList();

                foreach (BsonDocument document in documents)
                {
                    //deserealizing a Bdon document in a User object
                    User user = BsonSerializer.Deserialize<User>(document);
                    users.Add(user);
                }
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while loading users");
            }

            return users;
        }

        public User GetUserById(BsonObjectId id)
        {
          
            try
            {
                var collection = base.ReturnCollection(Database.noSqlProject, Collection.Users);

                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);

                var document = collection.Find(filter).FirstOrDefault();

                if (document != null)
                {
                    return BsonSerializer.Deserialize<User>(document);
                }
                else
                {
                    throw new Exception("the user does not exist");
                }

            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while getting the user");
            }

        }
        public User GetUserbyUsername(string username)
        {
            try
            {
                var collection = base.ReturnCollection(Database.noSqlProject, Collection.Users);
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);
                var document = collection.Find(filter).FirstOrDefault();

                if (document != null)
                {
                    return BsonSerializer.Deserialize<User>(document);
                }
                else
                {
                    throw new Exception("Username is wrong");
                }

            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong with loasing user");
            }

        }
        public void UpdatePassword(User user, Password password)
        {
            try
            {
                var collection = base.ReturnCollection(Database.noSqlProject, Collection.Users);
                var filter = Builders<BsonDocument>.Filter.Eq("_id", user.Id);
                BsonDocument docu = password.ToBsonDocument();
                var update = Builders<BsonDocument>.Update.Set("password", docu);
                collection.UpdateOne(filter, update);
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while changing the password");
            }
        }
        public bool CheckExistenceOfUserName(string username)
        {
            try {
                var collection = base.ReturnCollection(Database.noSqlProject, Collection.Users);
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);
                return collection.CountDocuments(filter) > 0;
            }
            catch (MongoException)
            {
                throw new Exception(" Unable to Connect to Mongo Db");
            }
            
        }

    }
}
