using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace DAL
{
    public class TicketDAO : DAO
    {

        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();

            //getting user collection
            var collection = ReturnCollection(Database.noSqlProject, "Ticket");

            //getting all documents in the collection 
            var documents = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument document in documents)
            {
                //deserealizing a Bdon document in a User object
                Ticket ticket = BsonSerializer.Deserialize<Ticket>(document);
                tickets.Add(ticket);
            }

            return tickets;
        }

        public void UpdateTicketStatus(Ticket ticket, TicketStatus status)
        {

            var collection = base.ReturnCollection(Database.noSqlProject,"Ticket");

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);

            var update = Builders<BsonDocument>.Update.Set("status", status);

            collection.UpdateOne(filter, update);
        }

        public Ticket GetTicketByUser(User user)
        {
            Ticket ticket = new Ticket();
            var collection = ReturnCollection(Database.noSqlProject,"Ticket");
            var builder = Builders<BsonDocument>.Filter;
            var baseFilter = builder.Eq("userID", user.Id) & builder.Eq("status", false);
            var documents = collection.Find(baseFilter, null).ToList();
            foreach (BsonDocument document in documents)
                ticket = BsonSerializer.Deserialize<Ticket>(document);
            return ticket;
        }


        public void UpdateTicketUser(Ticket ticket, User user)
        {

            var collection = base.ReturnCollection(Database.noSqlProject, "Ticket");


            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);

            var update = Builders<BsonDocument>.Update.Set("userID", user.Id);

            collection.UpdateOne(filter, update);
        }

        public List<Ticket> ArchiveTicketsByDate(DateTime date)
        {
            List<Ticket> tickets = new List<Ticket>();

            //getting user collection
            var collection = ReturnCollection(Database.noSqlProject, "Ticket");

            //getting all documents in the collection 
            var documents = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument document in documents)
            {
                //deserealizing a Bdon document in a User object
                Ticket ticket = BsonSerializer.Deserialize<Ticket>(document);
                tickets.Add(ticket);
            }

            return tickets;
        }

        //public void archiveticket(list<ticket> tickets)
        //{

        //    foreach(ticket te in tickets)
        //    {

        //    }

        //    var collection = base.returncollection(database.nosqlproject, "ticket");


        //    var filter = builders<bsondocument>.filter.eq("_id", ticket.id);

        //    var update = builders<bsondocument>.update.set("userid", user.id);

        //    collection.updateone(filter, update);
        //}
    }
}
