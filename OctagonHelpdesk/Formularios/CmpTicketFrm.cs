using OctagonHelpdesk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctagonHelpdesk.Formularios
{
    public partial class CmpTicketFrm : Form
    {
        RegTicketFrm regTicketFrm = new RegTicketFrm();
        public event Action<Ticket> TicketCreated;

        public Ticket ticket = new Ticket();
        public CmpTicketFrm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Se tiene q autogenerar el ID del ticket
            ticket.IDTicket = regTicketFrm.tickets.GetTickets().Count + 1;
            ticket.Subject = txtSubject.Text;
            ticket.Descripcion = txtDescription.Text;
            ticket.State = "Abierto";
            ticket.ActiveState = true;
            ticket.FechaCreacion = DateTime.Now;
            ticket.AsignadoA = "Sin Asignar";

            TicketCreated?.Invoke(ticket);

            this.Close();

        }
    }
}
