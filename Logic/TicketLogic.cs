using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;

namespace Logic
{
    public class TicketLogic
    {

        TicketDAO td = new TicketDAO();

        public List<Ticket> GetAllTicket()
        {
            return td.GetAllTickets();
        }

        public void UpdateTicketStatus(Ticket t, TicketStatus status)
        {
            td.UpdateTicketStatus(t, status);
        }

        public void UpdateTicketUser(Ticket t, User u )
        {
            td.UpdateTicketUser(t,u);
        }

        public Ticket GetTicketByUser(User user) => td.GetTicketByUser(user);

        public List<Ticket> GetAllTicketOfCurrentUser(User currentUser)
        {
            return td.GetAllTicketOfCurrentUser(currentUser);
        }
     
    

    }
}
