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
    public partial class LoginFrm : Form
    {
        public bool submitted = false;
        public UserModel CurrentUser { get; set; }
        public LoginFrm()
        {
            InitializeComponent();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Get from db
            string userdb = "santaclus";
            string passwordb = "1234";


            string inputuser = txbuser.Text;
            string inputpassword = txbpassword.Text;
            
            if (!string.IsNullOrEmpty(txbuser.Text) && !string.IsNullOrEmpty(txbpassword.Text))
            {

                CurrentUser = new UserModel { 
                    Nombre = txbuser.Text,
                    
                    
                
                };

                CurrentUser.ChecKPassword(inputpassword);




                this.DialogResult = DialogResult.OK;
                submitted = true;
                this.Close();
            } else
            {
                MessageBox.Show("Campos invalidos");
            }


        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
