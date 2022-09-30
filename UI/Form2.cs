using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DemoApp
{
    public partial class Form2 : Form
    {

        Databases db;
        public Form2()
        {
            InitializeComponent();
            db = new Databases();
            pnlCreateTicket.Show();
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.ticketDeadline = TicketDeadline.Seven;
            ticket.description = "computer crash";
            ticket.ticketPriority = TicketPriority.Low;
            ticket.ticketType = TicketType.Software;
            ticket.dateTime = DateTime.Now;
            ticket.subject = "computer crash";

            IMongoCollection<BsonDocument> collection = db.returnCollection("Ticket");

            BsonDocument document = ticket.ToBsonDocument();
            collection.InsertOne(document);

        }
    }
}
