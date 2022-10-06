using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class TicketLogic
    {

        TicketDAO td = new TicketDAO();

        public List<Ticket> GetAllTicket()
        {
            return td.GetAllTickets();
        }

        public void CloseTicket(Ticket t)
        {
            td.CloseTicket(t);
        }


        public Ticket GetTicketByUser(User user)=>td.GetTicketByUser(user);

    }
}
