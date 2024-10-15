namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMonodrogas = new Button();
            btnDroguerias = new Button();
            btnMedicamentos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnMonodrogas
            // 
            btnMonodrogas.Location = new Point(47, 12);
            btnMonodrogas.Name = "btnMonodrogas";
            btnMonodrogas.Size = new Size(134, 40);
            btnMonodrogas.TabIndex = 0;
            btnMonodrogas.Text = "Monodrogas";
            btnMonodrogas.UseVisualStyleBackColor = true;
            btnMonodrogas.Click += btnMonodrogas_Click;
            // 
            // btnDroguerias
            // 
            btnDroguerias.Location = new Point(47, 58);
            btnDroguerias.Name = "btnDroguerias";
            btnDroguerias.Size = new Size(134, 40);
            btnDroguerias.TabIndex = 1;
            btnDroguerias.Text = "Droguerias";
            btnDroguerias.UseVisualStyleBackColor = true;
            btnDroguerias.Click += btnDroguerias_Click;
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.Location = new Point(47, 104);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(134, 40);
            btnMedicamentos.TabIndex = 2;
            btnMedicamentos.Text = "Medicamentos";
            btnMedicamentos.UseVisualStyleBackColor = true;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(141, 167);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 202);
            Controls.Add(btnSalir);
            Controls.Add(btnMedicamentos);
            Controls.Add(btnDroguerias);
            Controls.Add(btnMonodrogas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMonodrogas;
        private Button btnDroguerias;
        private Button btnMedicamentos;
        private Button btnSalir;
    }
}
