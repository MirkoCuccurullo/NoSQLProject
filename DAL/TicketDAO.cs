using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Ticket> users = new List<Ticket>();

            //getting user collection
            var collection = ReturnCollection("Ticket");

            //getting all documents in the collection 
            var documents = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument document in documents)
            {
                //deserealizing a Bdon document in a User object
                Ticket user = BsonSerializer.Deserialize<Ticket>(document);
                users.Add(user);
            }

            return users;
        }

        public void CloseTicket(Ticket ticket)
        {
            var collection = ReturnCollection("Ticket");

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);

            var update = Builders<BsonDocument>.Update.Set("status", true);

            collection.UpdateOne(filter, update);
        }

        public Ticket GetTicketByUser(User user)
        {
            Ticket ticket = new Ticket();

            var collection = ReturnCollection("Ticket");

            var builder = Builders<BsonDocument>.Filter;
            var baseFilter = builder.Eq("_id", user.Id) & builder.Eq("status", true);

            var documents = collection.Find(baseFilter, null).ToList();

            foreach (BsonDocument document in documents)
            {
                Ticket te = BsonSerializer.Deserialize<Ticket>(document);
                ticket = te;
            }
            return ticket;
        }
    }
}
