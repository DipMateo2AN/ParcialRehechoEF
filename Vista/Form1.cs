namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMonodrogas_Click(object sender, EventArgs e)
        {
            var formMonodrogas = new FormMonodrogas();
            formMonodrogas.ShowDialog();
        }

        private void btnDroguerias_Click(object sender, EventArgs e)
        {
            var formDroguerias = new FormDroguerias();
            formDroguerias.ShowDialog();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            var formMedicamentos = new FormMedicamentos();
            formMedicamentos.ShowDialog();
        }
    }
}
