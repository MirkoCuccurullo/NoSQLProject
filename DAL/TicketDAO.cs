using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace DAL
{
    public class TicketDAO : DAO
    {

        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();

            try
            {

                //getting user collection
                var collection = ReturnCollection(Database.noSqlProject, Collection.Ticket);

                //getting all documents in the collection 
                var documents = collection.Find(new BsonDocument()).ToList();

                foreach (BsonDocument document in documents)
                {
                    //deserealizing a Bdon document in a User object
                    Ticket ticket = BsonSerializer.Deserialize<Ticket>(document);
                    tickets.Add(ticket);
                }
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while loading the tickets");
            }

            return tickets;
        }

        public List<Ticket> GetAllTicketOfCurrentUser(User currentUser)
        {
            List<Ticket> tickets = new List<Ticket>();

            try
            {

                //getting user collection
                var collection = ReturnCollection(Database.noSqlProject, Collection.Ticket);

                var filter = Builders<BsonDocument>.Filter.Eq("userID", currentUser.Id);

                //getting all documents in the collection with filter
                var documents = collection.Find(filter).ToList();

                foreach (BsonDocument document in documents)
                {
                    //deserealizing a Bdon document in a User object
                    Ticket ticket = BsonSerializer.Deserialize<Ticket>(document);
                    tickets.Add(ticket);
                }
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while loading the tickets");
            }

            return tickets;
        }

        public void UpdateTicketStatus(Ticket ticket, TicketStatus status)
        {
            try
            {

                var collection = base.ReturnCollection(Database.noSqlProject, Collection.Ticket);

                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);

                var update = Builders<BsonDocument>.Update.Set("status", status);

                collection.UpdateOne(filter, update);
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while updating a ticket");
            }
        }

        public Ticket GetTicketByUser(User user)
        {
            Ticket ticket = new Ticket();
            try
            {
                var collection = ReturnCollection(Database.noSqlProject, Collection.Ticket);
                var builder = Builders<BsonDocument>.Filter;
                var baseFilter = builder.Eq("userID", user.Id) & builder.Eq("status", TicketStatus.Open);
                var documents = collection.Find(baseFilter, null).ToList();

                foreach (BsonDocument document in documents)
                {
                   ticket = BsonSerializer.Deserialize<Ticket>(document);
                }
                

            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while loading ticket");
            }

            return ticket;
        }

        public void UpdateTicketUser(Ticket ticket, User user)
        {

            try
            {

                var collection = base.ReturnCollection(Database.noSqlProject, Collection.Ticket);


                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);

                var update = Builders<BsonDocument>.Update.Set("userID", user.Id);

                collection.UpdateOne(filter, update);
            }
            catch (MongoException)
            {
                throw new MongoException("something went wrong while updating user in the tiket");
            }
        }
       
                    
    }
 
}

