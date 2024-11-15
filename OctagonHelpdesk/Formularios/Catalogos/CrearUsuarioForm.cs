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
using OctagonHelpdesk.Models;
using OctagonHelpdesk.Models.Enum;

namespace OctagonHelpdesk.Formularios
{
    public partial class CrearUsuarioForm : Form
    {

        public event Action<UserModel> UsuarioCreated;
        private readonly UsuarioService usuarioServiceLocal;

        public UserModel usuario = new UserModel();
        public CrearUsuarioForm(UsuarioService usuarioService)
        {
            InitializeComponent();
            usuarioServiceLocal = usuarioService;
            
        }

        private void btnConfirmUserCreation_Click(object sender, EventArgs e)
        {
            bool usuarioValid = false;
            string name = tbName.Text;
            string lastname = tbLastname.Text;
            string email = tbEmail.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(email) || cmbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return;

            }
            else
            {
                usuario.IDUser = usuarioServiceLocal.AutogeneradorID();
                usuario.Name = name;
                usuario.Lastname = lastname;
                usuario.Email = email;


                usuario.CreationDate = DateTime.Now;
                usuario.ActiveStateU = true;
                usuario.Departamento = (Departament)cmbDepartamento.SelectedItem;
                usuarioValid = true;

            }
            // Se tiene que autogenerar el ID del usuario

            if (usuarioValid)
            {
                UsuarioCreated?.Invoke(usuario);

                this.Close();

            }
            else
            {
                MessageBox.Show("Algo anda mal, intentelo mas tarde");
            }


        }

        private void CrearUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void CrearUsuarioForm_Load_1(object sender, EventArgs e)
        {
            cmbDepartamento.Items.Clear();
            cmbDepartamento.SelectedIndex = -1;
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Departament));

            tbIDUser.Enabled = false;
        }
    }
}
