namespace Vista
{
    partial class FormDroguerias
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
            dgvDroguerias = new DataGridView();
            gBoxDroguerias = new GroupBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtDrogueriaId = new TextBox();
            label1 = new Label();
            txtRazonSocial = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDroguerias).BeginInit();
            gBoxDroguerias.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(614, 282);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvDroguerias
            // 
            dgvDroguerias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDroguerias.Location = new Point(252, 27);
            dgvDroguerias.Name = "dgvDroguerias";
            dgvDroguerias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDroguerias.Size = new Size(437, 249);
            dgvDroguerias.TabIndex = 5;
            dgvDroguerias.CellClick += dgvMonodrogas_CellClick;
            // 
            // gBoxDroguerias
            // 
            gBoxDroguerias.Controls.Add(label3);
            gBoxDroguerias.Controls.Add(txtEmail);
            gBoxDroguerias.Controls.Add(label);
            gBoxDroguerias.Controls.Add(txtDireccion);
            gBoxDroguerias.Controls.Add(label2);
            gBoxDroguerias.Controls.Add(txtDrogueriaId);
            gBoxDroguerias.Controls.Add(label1);
            gBoxDroguerias.Controls.Add(txtRazonSocial);
            gBoxDroguerias.Controls.Add(btnAgregar);
            gBoxDroguerias.Controls.Add(btnEliminar);
            gBoxDroguerias.Controls.Add(btnModificar);
            gBoxDroguerias.Location = new Point(17, 14);
            gBoxDroguerias.Name = "gBoxDroguerias";
            gBoxDroguerias.Size = new Size(200, 291);
            gBoxDroguerias.TabIndex = 6;
            gBoxDroguerias.TabStop = false;
            gBoxDroguerias.Text = "Datos Droguerias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 11;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 156);
            label.Name = "label";
            label.Size = new Size(60, 15);
            label.TabIndex = 10;
            label.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(83, 148);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Cuit:";
            // 
            // txtDrogueriaId
            // 
            txtDrogueriaId.Location = new Point(83, 32);
            txtDrogueriaId.Name = "txtDrogueriaId";
            txtDrogueriaId.Size = new Size(100, 23);
            txtDrogueriaId.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 79);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 6;
            label1.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(83, 71);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(100, 23);
            txtRazonSocial.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 194);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 252);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(171, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 223);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(171, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormDroguerias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 317);
            Controls.Add(btnSalir);
            Controls.Add(dgvDroguerias);
            Controls.Add(gBoxDroguerias);
            Name = "FormDroguerias";
            Text = "FormDroguerias";
            ((System.ComponentModel.ISupportInitialize)dgvDroguerias).EndInit();
            gBoxDroguerias.ResumeLayout(false);
            gBoxDroguerias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private DataGridView dgvDroguerias;
        private GroupBox gBoxDroguerias;
        private Label label3;
        private TextBox txtEmail;
        private Label label;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtDrogueriaId;
        private Label label1;
        private TextBox txtRazonSocial;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}