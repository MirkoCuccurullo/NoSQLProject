

namespace Model
{
    public class IncidentStatistics//statistic data that are used for populating the dashboard
    {
        public TicketType TicketType { get; set; }
        public int NumberOfIncident { get; set; }
        public int OpenIncident { get; set; }
        public int ClosedIncident { set; get; }

        public IncidentStatistics(TicketType ticketType, int numberOfIncident, int openIncident, int closedIncident)
        {
            TicketType = ticketType;
            NumberOfIncident = numberOfIncident;
            OpenIncident = openIncident;
            ClosedIncident = closedIncident;
        }
    }
}
