using Controladora;
using Modelo;

namespace Vista
{
    public partial class FormMedicamentos : Form
    {
        Medicamento medicamento;
        List<Drogueria> droguerias;
        public FormMedicamentos()
        {
            InitializeComponent();
            ActualizarGrilla();
            RellenarCmbDroguerias();
            RellenarCmbMonodroga();
            droguerias = new List<Drogueria>();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                medicamento = new Medicamento()
                {
                    NombreComercial = txtNombre.Text,
                    EsVentaLibre = chVentaLibre.Enabled,
                    PrecioVenta = int.Parse(txtPrecioVenta.Text),
                    Stock = int.Parse(txtStock.Text),
                    StockMinimo = int.Parse(txtStockMinimo.Text),
                    Monodroga = ControladoraMedicamentos.Instancia.BuscarMonodroga(cBoxMonodroga.Text)
                };
                if (droguerias.Count > 0)
                {
                    foreach (var d in droguerias)
                    {
                        medicamento.AgregarDrogueria(d);
                    }
                    if (ControladoraMedicamentos.Instancia.Agregar(medicamento))
                    {
                        ActualizarGrilla();
                        MessageBox.Show("Medicamento agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido agregar el medicamento.");
                    }
                }
                else
                {

                    MessageBox.Show("Debe agregar por lo menos una drogueria.");
                }
            }
            else
            {
                MessageBox.Show("Revisar ingreso de datos.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var medicamentoSeleccionado = (Medicamento)dgvMedicamentos.CurrentRow.DataBoundItem;
            if (ValidarDatos() && medicamentoSeleccionado != null)
            {
                medicamentoSeleccionado.NombreComercial = txtNombre.Text;
                medicamentoSeleccionado.EsVentaLibre = chVentaLibre.Enabled;
                medicamentoSeleccionado.PrecioVenta = int.Parse(txtPrecioVenta.Text);
                medicamentoSeleccionado.Stock = int.Parse(txtStock.Text);
                medicamentoSeleccionado.StockMinimo = int.Parse(txtStockMinimo.Text);
                medicamentoSeleccionado.Monodroga = ControladoraMedicamentos.Instancia.BuscarMonodroga(cBoxMonodroga.Text);

                if (ControladoraMedicamentos.Instancia.Modificar(medicamentoSeleccionado))
                {
                    ActualizarGrilla();
                    MessageBox.Show("Drogueria modificada correctamente.");
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
            var medicamentoSeleccionado = (Medicamento)dgvMedicamentos.CurrentRow.DataBoundItem;
            if (medicamentoSeleccionado != null)
            {
                if (ControladoraMedicamentos.Instancia.Eliminar(medicamentoSeleccionado))
                {
                    MessageBox.Show("Medicamento eliminado correctamente.");
                    droguerias.Clear();
                    ActualizarGrillaDrogueria();
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el medicamento.");
                }
            }
        }

        private void btnAgregarDrogueria_Click(object sender, EventArgs e)
        {
            int cuit = int.Parse(cBoxDrogueria.Text);
            if (cuit != 0)
            {
                Drogueria drogueriaSeleccionada = ControladoraDroguerias.Instancia.Droguerias().FirstOrDefault(z => z.Cuit == cuit);
                droguerias.Add(drogueriaSeleccionada);
                MessageBox.Show("Drogueria agregada correctamente.");
                ActualizarGrillaDrogueria();
            }
            else
            {
                MessageBox.Show("Revisar drogueria seleccionada.");

            }
        }

        private void btnEliminarDrogueria_Click(object sender, EventArgs e)
        {
            var drogueriaSeleccionada = (Drogueria)dgvDrogueriasDelMedicamento.CurrentRow.DataBoundItem;
            if (drogueriaSeleccionada != null)
            {
                droguerias.Remove(drogueriaSeleccionada);
                MessageBox.Show("Drogueria eliminada correctamente.");
                ActualizarGrillaDrogueria();
            }
        }


        private bool ValidarDatos()
        {
            if (txtNombre.Text != "" && txtPrecioVenta.Text != "" && txtStock.Text != "" && txtStockMinimo.Text != "" && cBoxDrogueria.Text != "" && cBoxMonodroga.Text != "")
            {
                return true;
            }
            return false;
        }

        private void ActualizarGrilla()
        {
            dgvMedicamentos.DataSource = null;
            dgvMedicamentos.DataSource = ControladoraMedicamentos.Instancia.Medicamentos();
        }

        private void RellenarCmbMonodroga()
        {
            cBoxMonodroga.DataSource = null;
            cBoxMonodroga.DataSource = ControladoraMonodrogas.Instancia.Monodrogas();
        }
        private void RellenarCmbDroguerias()
        {
            cBoxDrogueria.DataSource = null;
            cBoxDrogueria.DataSource = ControladoraDroguerias.Instancia.Droguerias();
        }

        private void ActualizarGrillaDrogueria()
        {
            dgvDrogueriasDelMedicamento.DataSource = null;
            dgvDrogueriasDelMedicamento.DataSource = droguerias.ToList();
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var medicamentoSeleccionado = (Medicamento)dgvMedicamentos.CurrentRow.DataBoundItem;
            dgvDrogueriasDelMedicamento.DataSource = null;
            dgvDrogueriasDelMedicamento.DataSource = medicamentoSeleccionado.ListarDroguerias();

            txtNombre.Text = medicamentoSeleccionado.NombreComercial;
            chVentaLibre.Enabled = medicamentoSeleccionado.EsVentaLibre;
            txtPrecioVenta.Text = medicamentoSeleccionado.PrecioVenta.ToString();
            txtStock.Text = medicamentoSeleccionado.Stock.ToString();
            txtStockMinimo.Text = medicamentoSeleccionado.StockMinimo.ToString();
            cBoxMonodroga.Text = medicamentoSeleccionado.Monodroga.MonodrogaId;

        }

        private void dgvDrogueriasDelMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminarDrogueria.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
