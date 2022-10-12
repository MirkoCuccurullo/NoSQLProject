﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum TicketType { Service, Software, Hardware }
    public enum TicketPriority { Low, Medium, High }
    public enum TicketDeadline { Seven = 7, Fourteen = 14, Twentysix = 26 }
    public enum UserRoles { Employee,ServiceDeskEmployee}
    public enum Branch { Haarlem,Amsterdam,HeadQuaters,Kunppeldam}

    public enum PanelName { CreateTicket, Dashboard,CreateUser, TicketOverview, UserOverview}

    public enum TicketStatus { Open, Escalated, Closed}



}
