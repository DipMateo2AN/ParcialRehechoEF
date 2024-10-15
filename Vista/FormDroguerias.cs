using Controladora;
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
    public partial class FormDroguerias : Form
    {
        public FormDroguerias()
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
                Drogueria drogueria = new Drogueria();
                drogueria.Direccion = txtDireccion.Text;
                drogueria.RazonSocial = txtRazonSocial.Text;
                drogueria.Email = txtEmail.Text;
                drogueria.Cuit = Convert.ToInt16(txtDrogueriaId.Text);
                if(ControladoraDroguerias.Instancia.Agregar(drogueria))
                {
                    ActualizarGrilla();
                    MessageBox.Show("Drogueria agregada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar la drogueria.");
                }
            }
            else
            {
                MessageBox.Show("No se ha podido agregar la drogueria.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var drogueriaSeleccionada = (Drogueria)dgvDroguerias.CurrentRow.DataBoundItem;
            if (ValidarDatos() && drogueriaSeleccionada != null)
            {
                Drogueria drogueria = new Drogueria();
                drogueria.Direccion = txtDireccion.Text;
                drogueria.RazonSocial = txtRazonSocial.Text;
                drogueria.Email = txtEmail.Text;
                drogueria.DrogueriaId = Convert.ToInt16(txtDrogueriaId.Text);
                ControladoraDroguerias.Instancia.Modificar(drogueria);
                ActualizarGrilla();
                MessageBox.Show("Drogueria modificada correctamente.");

            }
            else
            {
                MessageBox.Show("No se ha podido drogueria la monodroga.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var drogueriaSeleccionada = (Drogueria)dgvDroguerias.CurrentRow.DataBoundItem;
            if (drogueriaSeleccionada != null)
            {
                ControladoraDroguerias.Instancia.Eliminar(drogueriaSeleccionada);
                ActualizarGrilla();
                MessageBox.Show("Drogueria eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar la drogueria.");
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
            var drogueriaSeleccionada = (Drogueria)dgvDroguerias.CurrentRow.DataBoundItem;
            txtDireccion.Text = drogueriaSeleccionada.Direccion;
            txtEmail.Text = drogueriaSeleccionada.Email;
            txtRazonSocial.Text = drogueriaSeleccionada.RazonSocial;
            txtDrogueriaId.Text = drogueriaSeleccionada.Cuit.ToString();
        }

        private void ActualizarGrilla()
        {
            dgvDroguerias.DataSource = null;
            dgvDroguerias.DataSource = ControladoraDroguerias.Instancia.Droguerias();
        }

        private bool ValidarDatos()
        {
            if (txtDireccion.Text != "" && txtDrogueriaId.Text != "" && txtEmail.Text != "" && txtRazonSocial.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
