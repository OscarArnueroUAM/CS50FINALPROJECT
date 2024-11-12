using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctagonHelpdesk
{
    public partial class Frame : Form
    {
        bool sidebarexpand;
        bool ticketcollapsed;
        public Frame()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                panelouter.Width -= 10;
                if (panelouter.Width == panelouter.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                panelouter.Width += 10;
                if (panelouter.Width == panelouter.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void containerstimer_Tick(object sender, EventArgs e)
        {
            if (ticketcollapsed)
            {
                containerhome.Height -= 10;
                if (containerhome.Height == containerhome.MinimumSize.Height)
                {
                    ticketcollapsed = false;
                    containerstimer.Stop();
                }
            }
            else
            {
                containerhome.Height += 10;
                if (containerhome.Height == containerhome.MaximumSize.Height)
                {
                    ticketcollapsed = true;
                    containerstimer.Stop();
                }
            }
        }



        private void homebtn_Click(object sender, EventArgs e)
        {
            containerstimer.Start();
        }

        private void btnagregarticket_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnagregarticket_Click(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frame_Load(object sender, EventArgs e)
        {

        }
    }
}
