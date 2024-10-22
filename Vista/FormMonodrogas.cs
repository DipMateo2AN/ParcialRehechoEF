using Controladora;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormMonodrogas : Form
    {
        public FormMonodrogas()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Monodroga monodroga = new Monodroga();
                monodroga.Nombre = txtNombre.Text;
                monodroga.MonodrogaId = txtMonodrogaId.Text;
                if (ControladoraMonodrogas.Instancia.Agregar(monodroga))
                {
                    ActualizarGrilla();
                    LimpiarCampos();
                    MessageBox.Show("Monodroga agregada correctamente.");
                }
                else 
                {
                    MessageBox.Show("No se ha podido agregar la monodroga.");

                }
;

            }
            else
            {
                MessageBox.Show("No se ha podido agregar la monodroga.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var monodrogaSeleccionada = (Monodroga)dgvMonodrogas.CurrentRow.DataBoundItem;
            if (ValidarDatos() && monodrogaSeleccionada != null)
            {
                Monodroga monodroga = new Monodroga();
                monodroga.Nombre = txtNombre.Text;
                monodroga.MonodrogaId = txtMonodrogaId.Text;
                if (ControladoraMonodrogas.Instancia.Modificar(monodroga, monodrogaSeleccionada))
                {
                    ActualizarGrilla();
                    LimpiarCampos();
                    MessageBox.Show("Monodroga modificada correctamente.");
                }
                else 
                {
                    MessageBox.Show("No se ha podido modificar la monodroga.");
                }
            }
            else
            {
                MessageBox.Show("No se ha podido modificar la monodroga.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var monodrogaSeleccionada = (Monodroga)dgvMonodrogas.CurrentRow.DataBoundItem;
            if (monodrogaSeleccionada != null)
            {
                ControladoraMonodrogas.Instancia.Eliminar(monodrogaSeleccionada);
                ActualizarGrilla();
                LimpiarCampos();
                MessageBox.Show("Monodroga eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar la monodroga.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMonodrogas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            var monodrogaSeleccionada = (Monodroga)dgvMonodrogas.CurrentRow.DataBoundItem;
            txtMonodrogaId.Text = monodrogaSeleccionada.MonodrogaId;
            txtNombre.Text = monodrogaSeleccionada.Nombre;
        }

        private void ActualizarGrilla()
        {
            dgvMonodrogas.DataSource = null;
            dgvMonodrogas.DataSource = ControladoraMonodrogas.Instancia.Monodrogas();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtMonodrogaId.Clear();
        }

        private bool ValidarDatos()
        {
            if (txtNombre.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
