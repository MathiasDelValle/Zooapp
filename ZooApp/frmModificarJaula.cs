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
    public partial class frmModificarJaula : Form
    {
        private int jaulaEditando;
        public frmModificarJaula()
        {
            InitializeComponent();
            cmbEspacios.DataSource = JaulasController.vistaAltaJaulas();
            cmbEspacios.DisplayMember = "nombre";
            cmbEspacios.ValueMember = "id";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            jaulaEditando = 0;
            txtNombreJaula.Text = "";
            cmbEspacios.SelectedIndex = 0;
            panelEditar.Visible = false;
        }

        private void frmModificarJaula_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void cargarTabla()
        {
            this.tablaEspacios.Rows.Clear();
            List<Jaula> jaulas = JaulasController.listadoJaulas();
            foreach (Jaula ja in jaulas)
            {
                string[] newRow = new string[] {ja.getEspacio().Id.ToString(), ja.Id.ToString(), ja.Nombre, ja.getEspacio().Nombre};
                this.tablaEspacios.Rows.Add(newRow);
            }
            this.tablaEspacios.Refresh();
        }

        private void tablaEspacios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idEspacio = Int32.Parse(tablaEspacios.Rows[e.RowIndex].Cells[0].Value.ToString());
                int idJaula = Int32.Parse(tablaEspacios.Rows[e.RowIndex].Cells[1].Value.ToString());
                string nombre = tablaEspacios.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (e.ColumnIndex == tablaEspacios.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    jaulaEditando = idJaula;
                    cmbEspacios.SelectedValue = idEspacio;
                    txtNombreJaula.Text = nombre;
                    panelEditar.Visible = true;
                }
                else if (e.ColumnIndex == tablaEspacios.Columns["eliminar"].Index && e.RowIndex >= 0)
                {
                    JaulasController.eliminarJaula(idJaula);
                    this.cargarTabla();
                    MessageBox.Show("Jaula Eliminada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (JaulasController.modificarJaula(jaulaEditando, txtNombreJaula.Text, ((Espacio)cmbEspacios.SelectedItem).Id))
                {
                    jaulaEditando = 0;
                    txtNombreJaula.Text = "";
                    panelEditar.Visible = false;
                    this.cargarTabla();
                    MessageBox.Show("Modificacion de Jaula correcta");

                }
                else
                {
                    MessageBox.Show("No se puede editar la jaula");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
