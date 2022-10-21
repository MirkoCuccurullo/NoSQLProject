﻿using System;
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
            var baseFilter = builder.Eq("userID", user.Id) & builder.Eq("status", TicketStatus.Open);
            var documents = collection.Find(baseFilter, null).ToList();
            foreach (BsonDocument document in documents)
            {
                ticket = BsonSerializer.Deserialize<Ticket>(document);
            }

            return ticket;
        }

        public void UpdateTicketUser(Ticket ticket, User user)
        {

            var collection = base.ReturnCollection(Database.noSqlProject, "Ticket");


            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);

            var update = Builders<BsonDocument>.Update.Set("userID", user.Id);

            collection.UpdateOne(filter, update);
        }


        //Hyunwoo_ for archive doucuments

        public void ArchiveTickets(List<Ticket> tickets)
        {
            List<BsonDocument> documents = new List<BsonDocument>();
            foreach (Ticket te in tickets)
            {
                var documnent = te.ToBsonDocument();
                documents.Add(documnent);
            }
            AddManyDocumentToCollection(Database.Archive, documents, "Ticket");
            RemoveTickets(tickets);
        }

        public void RemoveTickets(List<Ticket> tickets)
        {
            foreach (Ticket ticket in tickets)
            {
                var collection = ReturnCollection(Database.noSqlProject, "Ticket");
                var condition = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);
                collection.DeleteOneAsync(condition);
            }
        }
        public void SortList(Ticket ticket)
        {
            var collection = base.ReturnCollection(Database.noSqlProject, "Ticket");

            //var filter = Builders<Ticket>.Filter.Eq(x => x.Status, client)
            //            & Builders<Ticket>.Filter.Eq(x => x.TP_PESSOA, 3)
            //            & Builders<Ticket>.Filter.Gte(x => x.FG_ATIVO, true);

            //var result = collection.Aggregate().Match(filter)
            //            .Project(p => new Ticket { CD_CLIENTE = p.CD_CLIENTE, ID_CENTRAL = p.ID_CENTRAL, FANTASIA = p.FANTASIA })
            //            .SortBy(p => p.).ToList();

            // var baseFilter = builder.Eq("userID", user.Id) & builder.Eq("status", TicketStatus.Open);

            //foreach (Ticket ticket in tickets)
            //{
            //    var collection = ReturnCollection(Database.noSqlProject, "Ticket");
            //    var condition = Builders<BsonDocument>.Filter.Eq("_id", ticket.ID);
            //    collection.DeleteOneAsync(condition);
            //}
            //    var collection = ReturnCollection(Database.noSqlProject, "Ticket");
            //    var filter = Builders<BsonDocument>.Filter.Empty;
            //    var sort = Builders<BsonDocument>.Sort.Descending("userID", user.Id);
            //collection.FindAsync(filter, new FindOptions<BsonDocument, BsonDocument>()
            //    {
            //        Sort = sort
            //    });


        }
 
    }
}
