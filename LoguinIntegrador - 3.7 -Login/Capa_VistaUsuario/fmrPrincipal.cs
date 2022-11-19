using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_VistaUsuario
{
    public partial class fmrPrincipal : Form
    {
        clsUsuario_CN usuarios = new clsUsuario_CN();
        private string idUsuario;
        private string id = "";


        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuarios.MostrarUsuarios();
            dgvUsuarios.Rows[0].Selected = false;
        }
        private void MostrarUsuarios()
        {

            clsUsuario_CN usuarios = new clsUsuario_CN();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios.MostrarUsuarios();
          
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            usuarios.AgregarUsuario(txtNombre.Text,txtApellido.Text,txtEMail.Text,txtCalle.Text, txtNroCalle.Text,txtDNI.Text);
            MessageBox.Show("se inserto correctamente");
            MostrarUsuarios();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                usuarios.Editar(txtNombre.Text, txtApellido.Text, txtEMail.Text, txtCalle.Text, txtNroCalle.Text, txtDNI.Text, idUsuario);
                MostrarUsuarios();
                Limpiar();


                MessageBox.Show("los datos se editaron correctamente");
            }
            else
                MessageBox.Show("Debe seleccionar una fila");
        }

     
        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                idUsuario = dgvUsuarios.CurrentRow.Cells["id"].Value.ToString();

                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvUsuarios.CurrentRow.Cells["apellido"].Value.ToString();
                txtEMail.Text = dgvUsuarios.CurrentRow.Cells["email"].Value.ToString();
                txtCalle.Text = dgvUsuarios.CurrentRow.Cells["nombreCalle"].Value.ToString();
                txtNroCalle.Text = dgvUsuarios.CurrentRow.Cells["NumeroCalle"].Value.ToString();
                txtDNI.Text = dgvUsuarios.CurrentRow.Cells["Dni"].Value.ToString();

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                id = dgvUsuarios.CurrentRow.Cells["Id"].Value.ToString();
                usuarios.Eliminar(id);
                MostrarUsuarios();
                Limpiar();
                MessageBox.Show("el producto se elimino correctamente");
            }
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEMail.Clear();
            txtCalle.Clear();
            txtDNI.Clear();
            txtNroCalle.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
