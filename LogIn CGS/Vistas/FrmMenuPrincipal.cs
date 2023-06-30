using Proyecto_CGS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CGS.Vistas
{
    public partial class FrmMenuPrincipal : Form
    {
        string _usuario;
        public FrmMenuPrincipal(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void btnGestionarUsuario_Click(object sender, EventArgs e)
        {
            FrmGestionarUsuario frmGestionarUsuario = new FrmGestionarUsuario(_usuario);
            frmGestionarUsuario.WindowState = FormWindowState.Maximized;
            frmGestionarUsuario.Show(Owner);
            
        }

        private void btnGestionarEquipos_Click(object sender, EventArgs e)
        {
            FrmGestionarEquipo frmGestionarEquipos = new FrmGestionarEquipo(_usuario);  
            frmGestionarEquipos.WindowState = FormWindowState.Maximized;
            frmGestionarEquipos.Show(Owner);
        }
    }
}
