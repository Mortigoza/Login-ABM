using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_VistaUsuario
{
    public partial class frmLogin : Form
    {
      
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsLogin log = new clsLogin();

            if (log.loginUsuario(txtUsuario.Text, txtContraseña.Text) == 1)
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                
                
                /*fmrPrincipal home = new fmrPrincipal();
                home.Show();*/
                this.Hide();

            }
            else
            {
                MessageBox.Show("CONTRASEÑA INCORRECTA");
            }
            /*
           clsLogin usuario = new clsLogin();
            var validarLoguin = usuario.loginUsuario(txtUsuario.Text, txtContraseña.Text);
            if (validarLoguin == true)
            {
                fmrPrincipal home = new fmrPrincipal();
                home.Show();
                this.Hide();
            }
             else
            {
                MessageBox.Show("Contraseña incorrecta");


            }*/
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

   

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
            }
        }
    }
}
