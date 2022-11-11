
namespace Model
{
    public enum Database { noSqlProject, Archive}
    public enum Collection { Users, Ticket}
    public enum TicketType { Service, Software, Hardware }
    public enum TicketPriority { Low = 3, Medium = 2, High = 1 }
    public enum TicketDeadline { Seven = 7, Fourteen = 14, Twentysix = 26 }
    public enum UserRoles { Employee,ServiceDeskEmployee}
    public enum Branch { Haarlem,Amsterdam,HeadQuaters,Kunppeldam}
    public enum PanelName { CreateTicket, Dashboard,CreateUser, TicketOverview, UserOverview}
    public enum TicketStatus { Open, Escalated, Closed}
    public enum Collections { Ticket, Users}
    public enum SortOrder { Ascending = 1, Descending = -1}
}
