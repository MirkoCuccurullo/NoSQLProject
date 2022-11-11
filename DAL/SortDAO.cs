using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;

namespace DAL
{
    public class SortDAO : DAO
    {
        //Sorting list of tickets by priority 
        public List<Ticket> SortList(int sortOrder)
        {
            List<Ticket> list = new List<Ticket>();

            var collection = ReturnCollection(Database.noSqlProject, Collection.Ticket);

            BsonDocument pipelineStage = new BsonDocument
            {
                {
                    "$sort", new BsonDocument
                    {
                        {"priority", sortOrder}
                    }
                }
            };

            BsonDocument[] pipeline = new BsonDocument[] { pipelineStage };

            List<BsonDocument> pResults = collection.Aggregate<BsonDocument>(pipeline).ToList();

            foreach (BsonDocument pResult in pResults)
            {

                Ticket ticket = BsonSerializer.Deserialize<Ticket>(pResult);
                list.Add(ticket);
            }


            return list;

        }
    }
}
