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

namespace OctagonHelpdesk.Formularios
{
    public partial class RegEmpleadosFrm : Form
    {
        public UsuarioService usuarios = new UsuarioService();
        public UserModel usuarioSel = new UserModel();
        public RegEmpleadosFrm()
        {
            InitializeComponent();
        }

        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            CrearUsuarioForm formEmpleado = new CrearUsuarioForm(usuarios);
            formEmpleado.UsuarioCreated += OnUsuarioCreated;
            formEmpleado.ShowDialog();
            MostrarUsuarios();
        }
        private void OnUsuarioCreated(UserModel usuario)
        {
            usuarios.AddUsuario(usuario);
        }
        private void MostrarUsuarios()
        {
            DgvRegUsuarios.DataSource = null;
            DgvRegUsuarios.DataSource = usuarios.GetUsuarios();
        }
    }
}
