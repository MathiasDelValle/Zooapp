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

namespace ZooApp
{
    public partial class frmAltaEspacio : Form
    {
        public frmAltaEspacio()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEspacio.Text.Trim() == "")
                {
                    MessageBox.Show("Debes colocar un nombre al espacio");
                }

                if (EspaciosController.altaEspacio(txtEspacio.Text))
                {
                    txtEspacio.Text = "";
                    MessageBox.Show("Alta de espacio realizada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al generar el alta");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
