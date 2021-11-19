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
    public partial class lsitado_Ventas : Form
    {
        public lsitado_Ventas()
        {
            InitializeComponent();
        }

        private void lsitado_Ventas_Load(object sender, EventArgs e)
        {
            this.tablaEspacios.Rows.Clear();
            List<Venta> ventas = TicketsController.listadoVentas();
            foreach (Venta v in ventas)
            {
                string[] newRow = new string[] { v.cliente.documento, v.cliente.nombre, v.ticket.Valor.ToString(), v.ticket.Espacios.ToString() };
                this.tablaEspacios.Rows.Add(newRow);
            }
            this.tablaEspacios.Refresh();
        }
    }
}
