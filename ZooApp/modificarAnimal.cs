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
    public partial class modificarAnimal : Form
    {
        private int animalEditando;

        public modificarAnimal()
        {
            InitializeComponent();
            cmbEspacios.DataSource = AnimalesController.vistaAltasAnimales();
            cmbEspacios.DisplayMember = "nombre";
            cmbEspacios.ValueMember = "id";
        }

        private void modificarAnimal_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void cargarTabla()
        {
            this.tablaEspacios.Rows.Clear();
            List<Animal> animales = AnimalesController.listadoAnimales();
            foreach (Animal a in animales)
            {
                string[] newRow = new string[] { a.getJaula().Id.ToString(), a.Id.ToString(), a.Nombre, a.getJaula().Nombre };
                this.tablaEspacios.Rows.Add(newRow);
            }
            this.tablaEspacios.Refresh();
        }

        private void tablaEspacios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idJaula = Int32.Parse(tablaEspacios.Rows[e.RowIndex].Cells[0].Value.ToString());
                int idAnimal = Int32.Parse(tablaEspacios.Rows[e.RowIndex].Cells[1].Value.ToString());
                string nombre = tablaEspacios.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (e.ColumnIndex == tablaEspacios.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    animalEditando = idAnimal;
                    cmbEspacios.SelectedValue = idJaula;
                    txtNombreJaula.Text = nombre;
                    panelEditar.Visible = true;
                }
                else if (e.ColumnIndex == tablaEspacios.Columns["eliminar"].Index && e.RowIndex >= 0)
                {
                    AnimalesController.eliminarAnimal(idAnimal);
                    this.cargarTabla();
                    MessageBox.Show("Animal eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            animalEditando = 0;
            txtNombreJaula.Text = "";
            cmbEspacios.SelectedIndex = 0;
            panelEditar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnimalesController.modificarAnimal(animalEditando, txtNombreJaula.Text, ((Jaula)cmbEspacios.SelectedItem).Id))
                {
                    animalEditando = 0;
                    txtNombreJaula.Text = "";
                    panelEditar.Visible = false;
                    this.cargarTabla();
                    MessageBox.Show("Modificacion de Animal correcta");

                }
                else
                {
                    MessageBox.Show("No se puede editar el animal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
