using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace DAL
{
    public class ArchiveDAO:DAO
    {

        public void ArchiveTickets(List<Ticket> tickets)
        {
            try
            {
                List<BsonDocument> documents = new List<BsonDocument>();
                foreach (Ticket te in tickets)
                {
                    var documnent = te.ToBsonDocument();
                    documents.Add(documnent);
                }
                AddManyDocumentToCollection(Database.Archive, documents, Collection.Ticket);
                RemoveTickets(tickets);
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while archiving the tickets");
            }
        }

        public void RemoveTickets(List<Ticket> tickets)
        {
            try
            {
                foreach (Ticket ticket in tickets)
                {
                    var collection = ReturnCollection(Database.noSqlProject, Collection.Ticket);
                    var condition = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);
                    collection.DeleteOneAsync(condition);
                }
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while deleting a ticket");
            }
        }
    }
}
