using OctagonHelpdesk.Models;
using OctagonHelpdesk.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;


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
            InitializeBinding();

        }

        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            CmpTicketFrm ticketFrm = new CmpTicketFrm(tickets);
            ticketFrm.TicketCreated += OnTicketCreated;
            ticketFrm.ShowDialog();
            MostrarTickets();

        }
        private void OnTicketCreated(Ticket ticket)
        {
            tickets.AddTicket(ticket);
            bindingSource.ResetBindings(false);
        }
      


        private void MostrarTickets()
        {
            bindingSource.DataSource = tickets.GetTickets();
            bindingSource.ResetBindings(false);
        }
        private void InitializeBinding()
        {
            bindingSource.DataSource = tickets.GetTickets();
            DgvRegTickets.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
            // Manejar el evento AddingNew para evitar la creación automática de nuevos elementos
            // Deshabilitar el comportamiento predeterminado del botón de eliminar
            // Manejar el evento Deleting para mostrar un MessageBox de confirmación

        }

        private void bindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            // Cancelar la adición automática de un nuevo elemento
            //e.Cancel = true;

            // Aquí puedes abrir tu formulario de creación de tickets
            BtnCreateTicket_Click(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
          

        }

        public void bindingSource_Deleting(object sender, CancelEventArgs e)
        {
            if (bindingSource.Current != null)
            {
                var result = MessageBox.Show("¿Está seguro de que desea eliminar este ticket?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bindingSource.RemoveCurrent();
                }
            }
        }

        private void DgvRegTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = DgvRegTickets.CurrentRow;
            ticketSel = (Ticket)currentRow.DataBoundItem;

        }
    }
}

