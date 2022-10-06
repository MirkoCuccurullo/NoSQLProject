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
    public class TicketDAO : DAO
    {

        public List<Ticket> GetAllTickets()
        {
            List<Ticket> users = new List<Ticket>();

            //getting user collection
            var collection = base.ReturnCollection("Ticket");

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
            var collection = base.ReturnCollection("Ticket");

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);

            var update = Builders<BsonDocument>.Update.Set("status", true);

            collection.UpdateOne(filter, update);
        }
    }
}
