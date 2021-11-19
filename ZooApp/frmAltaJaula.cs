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
    public partial class frmAltaJaula : Form
    {
        public frmAltaJaula()
        {
            InitializeComponent();
        }

        private void frmAltaJaula_Load(object sender, EventArgs e)
        {
            List<Espacio> j = JaulasController.vistaAltaJaulas();
            cmbEspacio.DataSource = j;
            cmbEspacio.DisplayMember = "nombre";
            cmbEspacio.ValueMember = "id";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreAnimal.Text.Trim() == "")
                {
                    MessageBox.Show("Debe seleccionar un nombre para la jaula");
                }

                if(JaulasController.altaJaula(txtNombreAnimal.Text, ((Espacio)cmbEspacio.SelectedItem).Id))
                {
                    txtNombreAnimal.Text = "";
                    MessageBox.Show("Alta de jaula realizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el alta");
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
