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
    public partial class RegEmpleadosFrm : Form
    {
        public RegEmpleadosFrm()
        {
            InitializeComponent();
        }

        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            CrearUsuarioForm formEmpleado = new CrearUsuarioForm();
            formEmpleado.ShowDialog();
        }
    }
}
