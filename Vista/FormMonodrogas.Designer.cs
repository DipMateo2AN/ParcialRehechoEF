namespace Vista
{
    partial class FormMonodrogas
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
            gBoxMonodrogas = new GroupBox();
            label2 = new Label();
            txtMonodrogaId = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            dgvMonodrogas = new DataGridView();
            btnSalir = new Button();
            gBoxMonodrogas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonodrogas).BeginInit();
            SuspendLayout();
            // 
            // gBoxMonodrogas
            // 
            gBoxMonodrogas.Controls.Add(label2);
            gBoxMonodrogas.Controls.Add(txtMonodrogaId);
            gBoxMonodrogas.Controls.Add(label1);
            gBoxMonodrogas.Controls.Add(txtNombre);
            gBoxMonodrogas.Controls.Add(btnAgregar);
            gBoxMonodrogas.Controls.Add(btnEliminar);
            gBoxMonodrogas.Controls.Add(btnModificar);
            gBoxMonodrogas.Location = new Point(12, 12);
            gBoxMonodrogas.Name = "gBoxMonodrogas";
            gBoxMonodrogas.Size = new Size(200, 217);
            gBoxMonodrogas.TabIndex = 0;
            gBoxMonodrogas.TabStop = false;
            gBoxMonodrogas.Text = "Datos Monodrogas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 8;
            label2.Text = "Id:";
            // 
            // txtMonodrogaId
            // 
            txtMonodrogaId.Location = new Point(83, 32);
            txtMonodrogaId.Name = "txtMonodrogaId";
            txtMonodrogaId.Size = new Size(100, 23);
            txtMonodrogaId.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 124);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 182);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(171, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 153);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(171, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvMonodrogas
            // 
            dgvMonodrogas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonodrogas.Location = new Point(247, 25);
            dgvMonodrogas.Name = "dgvMonodrogas";
            dgvMonodrogas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonodrogas.Size = new Size(220, 204);
            dgvMonodrogas.TabIndex = 0;
            dgvMonodrogas.CellClick += dgvMonodrogas_CellClick;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(392, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMonodrogas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 267);
            Controls.Add(btnSalir);
            Controls.Add(dgvMonodrogas);
            Controls.Add(gBoxMonodrogas);
            Name = "FormMonodrogas";
            Text = "FormMonodrogas";
            gBoxMonodrogas.ResumeLayout(false);
            gBoxMonodrogas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonodrogas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxMonodrogas;
        private DataGridView dgvMonodrogas;
        private Button btnAgregar;
        private Button btnModificar;
        private Label label1;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnSalir;
        private Label label2;
        private TextBox txtMonodrogaId;
    }
}