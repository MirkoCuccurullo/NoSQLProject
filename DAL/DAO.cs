using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;

        public DAO()
        {
            try
            {
                var builder = new ConfigurationBuilder()
                          .AddJsonFile("mongoConfig.json");
                var config = builder.Build();
                client = new MongoClient(config["Mongo:ConnString"]);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Unable to find the mongo Conifg file");
            }
            catch ( MongoClientException) 
            {
                throw new MongoClientException("connection failed connecting to Mongo Database");
            }
           
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

        protected IMongoCollection<BsonDocument> ReturnCollection(Database currentDatabase ,Collection collection)
        {
            var database = client.GetDatabase(currentDatabase.ToString());
            return database.GetCollection<BsonDocument>(collection.ToString());
        }

        public void AddDocumentToCollection(Database currentDatabase,BsonDocument document, Collection collectionName)
        {
            var collection = ReturnCollection(currentDatabase, collectionName);
            collection.InsertOne(document);
        }

        public void AddManyDocumentToCollection(Database currentDatabase, List<BsonDocument> documents, Collection collectionName)
        {
            var collection = ReturnCollection(currentDatabase, collectionName);
            collection.InsertMany(documents);
        }
    }
}
