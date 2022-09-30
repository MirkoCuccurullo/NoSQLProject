using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Ticket
    {
        public string ID { get; set; }
        public string UserID {get; set ;}
        public DateTime dateTime { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public TicketType ticketType { get; set; }
        public TicketPriority ticketPriority { get; set; }
        public TicketDeadline ticketDeadline { get; set; }

    }
}
