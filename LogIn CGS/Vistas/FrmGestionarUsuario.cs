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

namespace Proyecto_CGS.Vistas
{
    public partial class FrmGestionarUsuario : Form
    {
        string _usuario;
        public FrmGestionarUsuario(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
        UsuarioController _usuariocontrol = new UsuarioController();
        bool _Nuevo = true;

        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = _usuariocontrol.GetAll();
            lblUsuario.Text = _usuario;
        }
        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            groupBox_Usuario.Enabled = false;
            usuarioBindingSource.CancelEdit();
        }
        //boton de guardar 
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            var nusuario = (Usuario)usuarioBindingSource.Current;
            if(_Nuevo == true)
            {
                _usuariocontrol.Create(nusuario);
            }
            else
            {
                _usuariocontrol.Update(nusuario);
            }
            groupBox_Usuario.Enabled = false;
            usuarioBindingSource.DataSource = _usuariocontrol.GetAll();
        }
        //boton nuevo usuario
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            _Nuevo = true;
            groupBox_Usuario.Enabled = true;
            usuarioBindingSource.AddNew();
        }
        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eli = (Usuario)usuarioBindingSource.Current;
            DialogResult dlr = MessageBox.Show("QUIERES ELIMINAR ESTE USUARIO ?",
                "INFINITIX",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if(dlr == DialogResult.OK)
            {
                _usuariocontrol.Delete(eli);
            }
            usuarioBindingSource.DataSource = _usuariocontrol.GetAll();
        }
        //boton editar
        private void btn_editar_Click(object sender, EventArgs e)
        {
            _Nuevo = false;
            groupBox_Usuario.Enabled = true;
        }
        //boton Buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string parametro = txt_buscar.Text;
            usuarioBindingSource.DataSource = _usuariocontrol.Search(parametro);
        }
    }
}
