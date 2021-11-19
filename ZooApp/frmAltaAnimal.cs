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
    public partial class frmAltaAnimal : Form
    {
        private AnimalesController controller;

        public frmAltaAnimal()
        {
            this.controller = new AnimalesController();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaAnimal_Load(object sender, EventArgs e)
        {
            List<Jaula> j = AnimalesController.vistaAltasAnimales();
            cmbJaula.DataSource = j;
            cmbJaula.DisplayMember = "nombre";
            cmbJaula.ValueMember = "id";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if(AnimalesController.altaAnimal(txtNombreAnimal.Text, ((Jaula)cmbJaula.SelectedItem).Id))
            {
                txtNombreAnimal.Text = "";
                cmbJaula.SelectedIndex = 0;
                MessageBox.Show("Alta realizada correctamente");
                return;
            }

            MessageBox.Show("No se pudo realizar el alta");
        }
    }
}
