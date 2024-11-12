using OctagonHelpdesk.Models;
using OctagonHelpdesk.Services;
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
        
        public event Action<Ticket> TicketCreated;
        private readonly TicketService ticketServiceLocal;

        public Ticket ticket = new Ticket();
        public CmpTicketFrm(TicketService ticketService)
        {
            InitializeComponent();
            ticketServiceLocal = ticketService;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //Se tiene q autogenerar el ID del ticket
            ticket.IDTicket = ticketServiceLocal.AutogeneradorID();
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
