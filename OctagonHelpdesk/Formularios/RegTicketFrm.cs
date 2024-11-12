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
    public partial class RegTicketFrm : Form
    {
        public RegTicketFrm()
        {
            InitializeComponent();
            //this.currentUser = currentUser;
        }

        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            CmpTicketFrm ticketFrm = new CmpTicketFrm();
            ticketFrm.ShowDialog();
        }
    }
}
