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
    public partial class frmModificarEspacio : Form
    {

        private int espacioEditando;

        public frmModificarEspacio()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            espacioEditando = 0;
            txtNombreEspacio.Text = "";
            panelEditar.Visible = false;
        }

        private void frmModificarEspacio_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void cargarTabla()
        {
            this.tablaEspacios.Rows.Clear();
            List<Espacio> espacios = EspaciosController.obtenerEspacios();
            foreach (Espacio es in espacios)
            {
                string[] newRow = new string[] { es.Id.ToString(), es.Nombre};
                this.tablaEspacios.Rows.Add(newRow);
            }
            this.tablaEspacios.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (EspaciosController.editarEspacio(espacioEditando, txtNombreEspacio.Text))
                {
                    espacioEditando = 0;
                    txtNombreEspacio.Text = "";
                    panelEditar.Visible = false;
                    this.cargarTabla();
                    MessageBox.Show("Modificacion de Espacio correcta");

                }
                else
                {
                    MessageBox.Show("No se puede editar el espacio");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tablaEspacios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idEspacio = Int32.Parse(tablaEspacios.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nombre = tablaEspacios.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (e.ColumnIndex == tablaEspacios.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    espacioEditando = idEspacio;
                    txtNombreEspacio.Text = nombre;
                    panelEditar.Visible = true;
                }
                else if (e.ColumnIndex == tablaEspacios.Columns["eliminar"].Index && e.RowIndex >= 0)
                {
                    EspaciosController.bajaEspacio(idEspacio);
                    this.cargarTabla();
                    MessageBox.Show("Espacio Eliminado");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
