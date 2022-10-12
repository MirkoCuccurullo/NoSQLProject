using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System.Configuration;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://projectUser:hyunwoo@nosqldb.yqlm6qi.mongodb.net/test");

        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }

        protected IMongoCollection<BsonDocument> ReturnCollection(string collectionName)
        {
            //get the collection from database "noSqlProject"
            var database = client.GetDatabase("noSqlProject");
            return database.GetCollection<BsonDocument>(collectionName);
        }

        public void AddDocumentToCollection(BsonDocument document, string collectionName)
        {
            //add a document to a collection in "noSqlProject"
            var collection = ReturnCollection(collectionName);
            collection.InsertOne(document);

        }



    }


}
