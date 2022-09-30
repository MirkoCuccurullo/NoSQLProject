﻿using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://projectUser:1234@nosqldb.yqlm6qi.mongodb.net/test");
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

        public IMongoCollection<BsonDocument> ReturnCollection(string collectionName)
        {
            var database = client.GetDatabase("noSqlProject");
            return database.GetCollection<BsonDocument>(collectionName);
        }
    }


}
