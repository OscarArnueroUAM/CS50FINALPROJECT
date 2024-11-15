using OctagonHelpdesk.Models;
using OctagonHelpdesk.Models.Enum;
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
            ticket.StateProcess = cmbState.SelectedItem != null ? (State)cmbState.SelectedItem : State.Creado;
            ticket.ActiveState = true;
            ticket.FechaCreacion = DateTime.Now;
            ticket.Prioridad = cmbPriority.SelectedItem != null ? (Priority)cmbPriority.SelectedItem : Priority.Baja;
            ticket.AsignadoA = "Sin Asignar";
            if (ticket.StateProcess == State.Cerrado)
            {
                ticket.FechaCierre = DateTime.Now;
            }

            TicketCreated?.Invoke(ticket);

            this.Close();

        }

        private void CmpTicketFrm_Load(object sender, EventArgs e)
        {
            cmbState.Items.Clear();
            cmbState.SelectedIndex = -1;
            cmbState.DataSource = Enum.GetValues(typeof(State));

            cmbPriority.Items.Clear();
            cmbPriority.SelectedIndex = -1;
            cmbPriority.DataSource = Enum.GetValues(typeof(Priority));
        }
    }
}
