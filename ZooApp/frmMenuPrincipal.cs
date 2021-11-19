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
            lblNivel.Text = (usuLogeado.controlTotal()) ? "Control Total" : "Solo venta";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
