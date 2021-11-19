using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;

namespace ZooApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                AuthController controller = new AuthController();

                frmMenuPrincipal frmMenu = new frmMenuPrincipal(this, controller.login(txtUsuario.Text, txtPass.Text));
                this.Hide();
                this.txtUsuario.Text = "";
                this.txtPass.Text = "";
                frmMenu.Show();
                this.lblError.Visible = false;

            }
            catch (Exception ex)
            {
                this.lblError.Visible = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
