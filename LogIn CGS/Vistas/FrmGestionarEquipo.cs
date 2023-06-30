using Proyecto_CGS.Controladores;
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

namespace Proyecto_CGS
{
    public partial class FrmGestionarEquipo : Form
    {
        string _usuario;
        public FrmGestionarEquipo(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
        EquipoController _equipoController = new EquipoController();
        bool _isNew = true;

        private void btnnuevo_Click(object sender, EventArgs e)
        { 
            _isNew = true;
            groupBoxEquipo.Enabled = true;
            equipoBindingSource.AddNew();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false;
            groupBoxEquipo.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text;
            equipoBindingSource.DataSource = _equipoController.Search(par); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            var equipo = (Equipo)equipoBindingSource.Current;
            if(_isNew==true)
            {
                _equipoController.create(equipo);
            }
            else
            {
                _equipoController.Update(equipo);
            }
            groupBoxEquipo.Enabled = false;
            equipoBindingSource.DataSource = _equipoController.GetAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxEquipo.Enabled=false;
            equipoBindingSource.CancelEdit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var equi = (Equipo)equipoBindingSource.Current;
            DialogResult dlr = MessageBox.Show("Estas seguro que deseas eliminar?", "INFINYTIX", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dlr == DialogResult.OK)
            {
                _equipoController.Delete(equi);
            }
            equipoBindingSource.DataSource = _equipoController.GetAll();    

        }

        private void FrmGestionarEquipo_Load(object sender, EventArgs e)
        {
            equipoBindingSource.DataSource = _equipoController.GetAll();
            lblUsuario.Text = _usuario;
        }
    }
}
