using DAL;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class ArchiveLogic
    {
        ArchiveDAO archiveDAO = new ArchiveDAO();

        public void ArchiveTickets(List<Ticket> tickets) => archiveDAO.ArchiveTickets(tickets);

    }
}
