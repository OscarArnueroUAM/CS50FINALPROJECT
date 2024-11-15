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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OctagonHelpdesk.Formularios
{
    public partial class RegEmpleadosFrm : Form
    {
        public UsuarioService usuarios = new UsuarioService();
        public UserModel usuarioSel = new UserModel();
        public RegEmpleadosFrm()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            bindingSource1.DataSource = usuarios.GetUsuarios();
            DgvRegUsuarios.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            // Manejar el evento AddingNew para evitar la creación automática de nuevos elementos
            // Deshabilitar el comportamiento predeterminado del botón de eliminar
            // Manejar el evento Deleting para mostrar un MessageBox de confirmación

        }
        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            
            MostrarUsuarios();
        }
        private void OnUsuarioCreated(UserModel usuario)
        {
            usuarios.AddUsuario(usuario);
            bindingSource1.ResetBindings(false);
        }
        private void MostrarUsuarios()
        {
            DgvRegUsuarios.DataSource = null;
            DgvRegUsuarios.DataSource = usuarios.GetUsuarios();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_AddingNew(object sender, AddingNewEventArgs e)
        {
            CrearUsuarioForm formEmpleado = new CrearUsuarioForm(usuarios);
            formEmpleado.UsuarioCreated += OnUsuarioCreated;
            formEmpleado.ShowDialog();
        }
    }
}
