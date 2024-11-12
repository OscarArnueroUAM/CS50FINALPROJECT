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
        public Frame()
        {
            InitializeComponent();
        }

        private void panelouter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home");
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
                panelouter.Width +=10;
                if (panelouter.Width == panelouter.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }
    }
}
