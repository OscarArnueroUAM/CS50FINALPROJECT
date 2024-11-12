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

namespace TicketFrm
{
    public partial class TicketFrm : Form
    {
        public TicketFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Cambios guardados exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres cancelar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
               
                MessageBox.Show("Los cambios han sido cancelados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CrearNuevoTicket()
        {
            int empleadoID = Sesion.EmpleadoID;
            Ticket nuevoTicket = new Ticket(empleadoID);
            txtCreadorPor.Text = nuevoTicket.CreadorPor.ToString();
        }
    }
}


