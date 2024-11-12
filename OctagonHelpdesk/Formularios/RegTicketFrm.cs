using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OctagonHelpdesk.Models;
using OctagonHelpdesk.Services;


namespace OctagonHelpdesk.Formularios
{
    public partial class RegTicketFrm : Form
    {
        public TicketService tickets = new TicketService();
        public Ticket ticketSel = new Ticket();
        public RegTicketFrm()
        {
            InitializeComponent();
            //this.currentUser = currentUser;
        }

        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            CmpTicketFrm ticketFrm = new CmpTicketFrm();
            ticketFrm.TicketCreated += OnTicketCreated;
            ticketFrm.ShowDialog();
            MostrarTickets();

        }
        private void OnTicketCreated(Ticket ticket)
        {
            tickets.AddTicket(ticket);
        }

        private void MostrarTickets()
        {
            DgvRegTickets.DataSource = null;
            DgvRegTickets.DataSource = tickets.GetTickets();
        }
    }
}
