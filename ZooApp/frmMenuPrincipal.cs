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
    public partial class frmMenuPrincipal : Form
    {
        public Usuario usuLogeado;
        public frmLogin frmLogin;
        //public ServicioSouvenirs serviSouvenirs;
        //public ServicioCompras serviCompras;
        //public Form formularioActivo;


        public frmMenuPrincipal(frmLogin frmPadre, Usuario usuLogeado)
        {
            this.frmLogin = frmPadre;
            this.usuLogeado = usuLogeado;
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuarioLogeado.Text = usuLogeado.nombre;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (!usuLogeado.controlTotal())
            {
                lblNivel.Text = "Solo Venta";
                menuAnimales.Visible = false;
                menuJaulas.Visible = false;
                menuEspacios.Visible = false;
                menuVentas.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmLogin.Show();
            this.Dispose();
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmLogin.Show();
            this.Dispose();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAnimal frmAltaAnimal = new frmAltaAnimal();
            frmAltaAnimal.TopLevel = false;
            frmAltaAnimal.Parent = this;
            frmAltaAnimal.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAltaEspacio frmAltaEspacio = new frmAltaEspacio();
            frmAltaEspacio.TopLevel = false;
            frmAltaEspacio.Parent = this;
            frmAltaEspacio.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAltaJaula frmAltaJaula = new frmAltaJaula();
            frmAltaJaula.TopLevel = false;
            frmAltaJaula.Parent = this;
            frmAltaJaula.Show();
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModificarEspacio modificarEspacio = new frmModificarEspacio();
            modificarEspacio.TopLevel = false;
            modificarEspacio.Parent = this;
            modificarEspacio.Show();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModificarJaula modificarJaula = new frmModificarJaula();
            modificarJaula.TopLevel = false;
            modificarJaula.Parent = this;
            modificarJaula.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarAnimal modificarAnimal = new modificarAnimal();
            modificarAnimal.TopLevel = false;
            modificarAnimal.Parent = this;
            modificarAnimal.Show();
        }
    }
}
