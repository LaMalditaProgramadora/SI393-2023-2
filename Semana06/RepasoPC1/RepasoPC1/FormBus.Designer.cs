namespace RepasoPC1
{
    partial class FormBus
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
            label2 = new Label();
            tbBusMatricula = new TextBox();
            tbBusConductor = new TextBox();
            label3 = new Label();
            dgvBuses = new DataGridView();
            cbBusTipo = new ComboBox();
            label4 = new Label();
            btnBusRegistrar = new Button();
            btnSalir = new Button();
            btnVerRutas = new Button();
            btnReportes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBuses).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 31);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Matrícula:";
            // 
            // tbBusMatricula
            // 
            tbBusMatricula.Location = new Point(102, 28);
            tbBusMatricula.Name = "tbBusMatricula";
            tbBusMatricula.Size = new Size(160, 23);
            tbBusMatricula.TabIndex = 3;
            // 
            // tbBusConductor
            // 
            tbBusConductor.Location = new Point(102, 86);
            tbBusConductor.Name = "tbBusConductor";
            tbBusConductor.Size = new Size(160, 23);
            tbBusConductor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 89);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Conductor:";
            // 
            // dgvBuses
            // 
            dgvBuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuses.Location = new Point(296, 28);
            dgvBuses.Name = "dgvBuses";
            dgvBuses.RowTemplate.Height = 25;
            dgvBuses.Size = new Size(479, 221);
            dgvBuses.TabIndex = 7;
            // 
            // cbBusTipo
            // 
            cbBusTipo.FormattingEnabled = true;
            cbBusTipo.Items.AddRange(new object[] { "Tipo 1", "Tipo 2" });
            cbBusTipo.Location = new Point(102, 57);
            cbBusTipo.Name = "cbBusTipo";
            cbBusTipo.Size = new Size(160, 23);
            cbBusTipo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 60);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Tipo:";
            // 
            // btnBusRegistrar
            // 
            btnBusRegistrar.Location = new Point(120, 139);
            btnBusRegistrar.Name = "btnBusRegistrar";
            btnBusRegistrar.Size = new Size(75, 23);
            btnBusRegistrar.TabIndex = 10;
            btnBusRegistrar.Text = "Registrar";
            btnBusRegistrar.UseVisualStyleBackColor = true;
            btnBusRegistrar.Click += btnBusRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(120, 226);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVerRutas
            // 
            btnVerRutas.Location = new Point(120, 168);
            btnVerRutas.Name = "btnVerRutas";
            btnVerRutas.Size = new Size(75, 23);
            btnVerRutas.TabIndex = 12;
            btnVerRutas.Text = "Ver Rutas";
            btnVerRutas.UseVisualStyleBackColor = true;
            btnVerRutas.Click += btnVerRutas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(120, 197);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(75, 23);
            btnReportes.TabIndex = 13;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // FormBus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 281);
            Controls.Add(btnReportes);
            Controls.Add(btnVerRutas);
            Controls.Add(btnSalir);
            Controls.Add(btnBusRegistrar);
            Controls.Add(label4);
            Controls.Add(cbBusTipo);
            Controls.Add(dgvBuses);
            Controls.Add(label3);
            Controls.Add(tbBusConductor);
            Controls.Add(tbBusMatricula);
            Controls.Add(label2);
            Name = "FormBus";
            Text = "Información de Buses";
            ((System.ComponentModel.ISupportInitialize)dgvBuses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tbBusMatricula;
        private TextBox tbBusConductor;
        private Label label3;
        private DataGridView dgvBuses;
        private ComboBox cbBusTipo;
        private Label label4;
        private Button btnBusRegistrar;
        private Button btnSalir;
        private Button btnVerRutas;
        private Button btnReportes;
        private DataGridViewTextBoxColumn Matrícula;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Conductor;
    }
}