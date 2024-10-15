namespace Vista
{
    partial class FormMedicamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            dgvMedicamentos = new DataGridView();
            gBoxDroguerias = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            cBoxMonodroga = new ComboBox();
            chVentaLibre = new CheckBox();
            label3 = new Label();
            txtStock = new TextBox();
            label = new Label();
            txtStockMinimo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtPrecioVenta = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            cBoxDrogueria = new ComboBox();
            dgvDrogueriasDelMedicamento = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            btnAgregarDrogueria = new Button();
            btnEliminarDrogueria = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            gBoxDroguerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrogueriasDelMedicamento).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(629, 342);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(267, 228);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.Size = new Size(437, 108);
            dgvMedicamentos.TabIndex = 8;
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;
            // 
            // gBoxDroguerias
            // 
            gBoxDroguerias.Controls.Add(label8);
            gBoxDroguerias.Controls.Add(label7);
            gBoxDroguerias.Controls.Add(cBoxMonodroga);
            gBoxDroguerias.Controls.Add(chVentaLibre);
            gBoxDroguerias.Controls.Add(label3);
            gBoxDroguerias.Controls.Add(txtStock);
            gBoxDroguerias.Controls.Add(label);
            gBoxDroguerias.Controls.Add(txtStockMinimo);
            gBoxDroguerias.Controls.Add(label2);
            gBoxDroguerias.Controls.Add(txtNombre);
            gBoxDroguerias.Controls.Add(label1);
            gBoxDroguerias.Controls.Add(txtPrecioVenta);
            gBoxDroguerias.Controls.Add(btnAgregar);
            gBoxDroguerias.Controls.Add(btnEliminar);
            gBoxDroguerias.Controls.Add(btnModificar);
            gBoxDroguerias.Location = new Point(22, 8);
            gBoxDroguerias.Name = "gBoxDroguerias";
            gBoxDroguerias.Size = new Size(200, 351);
            gBoxDroguerias.TabIndex = 9;
            gBoxDroguerias.TabStop = false;
            gBoxDroguerias.Text = "Datos Medicamentos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 216);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 17;
            label8.Text = "Monodroga:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 187);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 16;
            label7.Text = "Venta libre:";
            // 
            // cBoxMonodroga
            // 
            cBoxMonodroga.FormattingEnabled = true;
            cBoxMonodroga.Location = new Point(83, 208);
            cBoxMonodroga.Name = "cBoxMonodroga";
            cBoxMonodroga.Size = new Size(100, 23);
            cBoxMonodroga.TabIndex = 15;
            // 
            // chVentaLibre
            // 
            chVentaLibre.AutoSize = true;
            chVentaLibre.Location = new Point(120, 188);
            chVentaLibre.Name = "chVentaLibre";
            chVentaLibre.Size = new Size(15, 14);
            chVentaLibre.TabIndex = 13;
            chVentaLibre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(83, 109);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 11;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(0, 156);
            label.Name = "label";
            label.Size = new Size(84, 15);
            label.TabIndex = 10;
            label.Text = "Stock minimo:";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(83, 148);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(100, 23);
            txtStockMinimo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 79);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Precio venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(83, 71);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 256);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 314);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(171, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 285);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(171, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cBoxDrogueria
            // 
            cBoxDrogueria.FormattingEnabled = true;
            cBoxDrogueria.Location = new Point(583, 26);
            cBoxDrogueria.Name = "cBoxDrogueria";
            cBoxDrogueria.Size = new Size(121, 23);
            cBoxDrogueria.TabIndex = 14;
            // 
            // dgvDrogueriasDelMedicamento
            // 
            dgvDrogueriasDelMedicamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrogueriasDelMedicamento.Location = new Point(267, 79);
            dgvDrogueriasDelMedicamento.Name = "dgvDrogueriasDelMedicamento";
            dgvDrogueriasDelMedicamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrogueriasDelMedicamento.Size = new Size(437, 108);
            dgvDrogueriasDelMedicamento.TabIndex = 11;
            dgvDrogueriasDelMedicamento.CellClick += dgvDrogueriasDelMedicamento_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 34);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 16;
            label4.Text = "Droguerias:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 210);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 17;
            label5.Text = "Medicamentos:";
            // 
            // btnAgregarDrogueria
            // 
            btnAgregarDrogueria.Location = new Point(488, 52);
            btnAgregarDrogueria.Name = "btnAgregarDrogueria";
            btnAgregarDrogueria.Size = new Size(105, 23);
            btnAgregarDrogueria.TabIndex = 16;
            btnAgregarDrogueria.Text = "Agregar";
            btnAgregarDrogueria.UseVisualStyleBackColor = true;
            btnAgregarDrogueria.Click += btnAgregarDrogueria_Click;
            // 
            // btnEliminarDrogueria
            // 
            btnEliminarDrogueria.Enabled = false;
            btnEliminarDrogueria.Location = new Point(599, 52);
            btnEliminarDrogueria.Name = "btnEliminarDrogueria";
            btnEliminarDrogueria.Size = new Size(105, 23);
            btnEliminarDrogueria.TabIndex = 17;
            btnEliminarDrogueria.Text = "Eliminar";
            btnEliminarDrogueria.UseVisualStyleBackColor = true;
            btnEliminarDrogueria.Click += btnEliminarDrogueria_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 61);
            label6.Name = "label6";
            label6.Size = new Size(160, 15);
            label6.TabIndex = 18;
            label6.Text = "Droguerias del medicamento";
            // 
            // FormMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 371);
            Controls.Add(label6);
            Controls.Add(btnAgregarDrogueria);
            Controls.Add(btnEliminarDrogueria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvDrogueriasDelMedicamento);
            Controls.Add(cBoxDrogueria);
            Controls.Add(btnSalir);
            Controls.Add(dgvMedicamentos);
            Controls.Add(gBoxDroguerias);
            Name = "FormMedicamentos";
            Text = "FormMedicamentos";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            gBoxDroguerias.ResumeLayout(false);
            gBoxDroguerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrogueriasDelMedicamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private DataGridView dgvMedicamentos;
        private GroupBox gBoxDroguerias;
        private Label label3;
        private TextBox txtStock;
        private Label label;
        private TextBox txtStockMinimo;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtPrecioVenta;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private ComboBox cBoxMonodroga;
        private CheckBox chVentaLibre;
        private ComboBox cBoxDrogueria;
        private DataGridView dgvDrogueriasDelMedicamento;
        private Label label4;
        private Label label5;
        private Button btnAgregarDrogueria;
        private Button btnEliminarDrogueria;
        private Label label6;
        private Label label8;
        private Label label7;
    }
}