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
    public partial class frmVentaTicket : Form
    {
        public frmVentaTicket()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmVentaTicket_Load(object sender, EventArgs e)
        {
            cmbTicket.DataSource = TicketsController.listadoTickets();
            cmbTicket.DisplayMember = "nombre";
            cmbTicket.ValueMember = "id";
        }

        private void cmbTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ticket t = (Ticket)cmbTicket.SelectedItem;
            if(t.Espacios == 0 || t.Espacios == -1)
            {
                cantEspacios.Text = "TODOS LOS ESPACIOS";
            }
            else
            {
                cantEspacios.Text = t.Espacios.ToString();
            }
            
            costo.Text = "$ " + t.Valor;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumento.Text.Trim() == "" || txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Debe completar los campos obligatorios");
                }
                Ticket t = (Ticket)cmbTicket.SelectedItem;
                if (TicketsController.altaVenta(txtDocumento.Text, txtNombre.Text,t))
                {
                    txtNombre.Text = "";
                    txtDocumento.Text = "";
                    cmbTicket.SelectedIndex = 0;
                    MessageBox.Show("Venta realizada correctamente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al realizar la venta");
            }
        }
    }
}
