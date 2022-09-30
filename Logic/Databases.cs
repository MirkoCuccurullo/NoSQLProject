using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Logic
{
    public class Databases
    {
        private DAO dao;
        public Databases()
        {
            dao = new DAO();
        }

        public List<Databases_Model> Get_All_Databases()
        {
            return dao.GetDatabases();
        }

        public IMongoCollection<BsonDocument> returnCollection(string collectionName)
        {
            return dao.ReturnCollection(collectionName);
        }
    }
}
