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

namespace OctagonHelpdesk.Formularios
{
    public partial class TicketFrm : Form
    {
        public TicketFrm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.TicketFrm_Load);
            CrearNuevoTicket();
        }

        private void CrearNuevoTicket()
        {
            int empleadoID = Sesion.EmpleadoID;
            Ticket nuevoTicket = new Ticket(empleadoID);
            txtCreadorPor.Text = nuevoTicket.CreadorPor.ToString();
        }

        private void TicketFrm_Load(object sender, EventArgs e)
        {
            CrearNuevoTicket();
        }
    }

}

