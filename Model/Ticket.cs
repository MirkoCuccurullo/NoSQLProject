using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Ticket
    {
        [BsonId]
        public BsonObjectId ID { get; set; }
        [BsonElement("userID")]
        public BsonObjectId UserID {get; set ;}
        [BsonElement("DateReport")]
        public DateTime dateTime { get; set; }
        [BsonElement("incident")]
        public string[] incident = new string[2];
        [BsonElement("type")]
        public TicketType ticketType { get; set; }
        [BsonElement("priority")]
        public TicketPriority ticketPriority { get; set; }
        [BsonElement("deadline")]
        public TicketDeadline ticketDeadline { get; set; }

    }
}
