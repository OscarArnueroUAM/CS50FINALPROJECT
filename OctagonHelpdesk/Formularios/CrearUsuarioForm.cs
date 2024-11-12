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
            // Se tiene que autogenerar el ID del usuario
            usuario.IDUser = usuarioServiceLocal.AutogeneradorID();
            usuario.Name = tbName.Text;
            usuario.Email = tbEmail.Text;
            usuario.CreationDate = DateTime.Now;
            usuario.ActiveStateU = true;

            UsuarioCreated?.Invoke(usuario);

            this.Close();

        }
    }
}
