using DAL;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class SortLogic
    {
        SortDAO sortDAO = new SortDAO();
        public List<Ticket> SortList(SortOrder sortOrder)
        {
            return sortDAO.SortList(sortOrder);
        }
    }
}
