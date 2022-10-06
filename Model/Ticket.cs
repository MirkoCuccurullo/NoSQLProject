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
        public DateTime DateTime { get; set; }
        [BsonElement("incident")]
        public BsonDocument IncidentDocument = new BsonDocument();
        [BsonElement("type")]
        public TicketType TicketType { get; set; }
        [BsonElement("priority")]
        public TicketPriority TicketPriority { get; set; }
        [BsonElement("deadline")]
        public TicketDeadline TicketDeadline { get; set; }
        [BsonElement("status")]
        public bool Status { get; set; }

    }
}
