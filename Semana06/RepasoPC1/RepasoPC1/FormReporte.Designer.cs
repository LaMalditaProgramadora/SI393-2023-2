namespace RepasoPC1
{
    partial class FormReporte
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
            dgvBuses = new DataGridView();
            dgvRutas = new DataGridView();
            btnBuscarBusesRutasMasLargas = new Button();
            btnBuscarBusesConMenosRutas = new Button();
            tbBusConductor = new TextBox();
            label1 = new Label();
            btnBuscarRutasPorConductorBus = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
            SuspendLayout();
            // 
            // dgvBuses
            // 
            dgvBuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuses.Location = new Point(219, 24);
            dgvBuses.Name = "dgvBuses";
            dgvBuses.RowTemplate.Height = 25;
            dgvBuses.Size = new Size(479, 186);
            dgvBuses.TabIndex = 8;
            // 
            // dgvRutas
            // 
            dgvRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRutas.Location = new Point(219, 228);
            dgvRutas.Name = "dgvRutas";
            dgvRutas.RowTemplate.Height = 25;
            dgvRutas.Size = new Size(479, 186);
            dgvRutas.TabIndex = 19;
            // 
            // btnBuscarBusesRutasMasLargas
            // 
            btnBuscarBusesRutasMasLargas.Location = new Point(40, 24);
            btnBuscarBusesRutasMasLargas.Name = "btnBuscarBusesRutasMasLargas";
            btnBuscarBusesRutasMasLargas.Size = new Size(137, 41);
            btnBuscarBusesRutasMasLargas.TabIndex = 20;
            btnBuscarBusesRutasMasLargas.Text = "Buscar Buses con Rutas más Largas";
            btnBuscarBusesRutasMasLargas.UseVisualStyleBackColor = true;
            btnBuscarBusesRutasMasLargas.Click += btnBuscarBusesRutasMasLargas_Click;
            // 
            // btnBuscarBusesConMenosRutas
            // 
            btnBuscarBusesConMenosRutas.Location = new Point(40, 71);
            btnBuscarBusesConMenosRutas.Name = "btnBuscarBusesConMenosRutas";
            btnBuscarBusesConMenosRutas.Size = new Size(137, 41);
            btnBuscarBusesConMenosRutas.TabIndex = 21;
            btnBuscarBusesConMenosRutas.Text = "Buscar Buses con Menos Rutas";
            btnBuscarBusesConMenosRutas.UseVisualStyleBackColor = true;
            btnBuscarBusesConMenosRutas.Click += btnBuscarBusesConMenosRutas_Click;
            // 
            // tbBusConductor
            // 
            tbBusConductor.Location = new Point(40, 250);
            tbBusConductor.Name = "tbBusConductor";
            tbBusConductor.Size = new Size(137, 23);
            tbBusConductor.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 232);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 23;
            label1.Text = "Conductor:";
            // 
            // btnBuscarRutasPorConductorBus
            // 
            btnBuscarRutasPorConductorBus.Location = new Point(40, 279);
            btnBuscarRutasPorConductorBus.Name = "btnBuscarRutasPorConductorBus";
            btnBuscarRutasPorConductorBus.Size = new Size(137, 41);
            btnBuscarRutasPorConductorBus.TabIndex = 24;
            btnBuscarRutasPorConductorBus.Text = "Buscar Rutas Por Conductor de Bus";
            btnBuscarRutasPorConductorBus.UseVisualStyleBackColor = true;
            btnBuscarRutasPorConductorBus.Click += btnBuscarRutasPorConductorBus_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(40, 391);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 23);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 440);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscarRutasPorConductorBus);
            Controls.Add(label1);
            Controls.Add(tbBusConductor);
            Controls.Add(btnBuscarBusesConMenosRutas);
            Controls.Add(btnBuscarBusesRutasMasLargas);
            Controls.Add(dgvRutas);
            Controls.Add(dgvBuses);
            Name = "FormReporte";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dgvBuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBuses;
        private DataGridView dgvRutas;
        private Button btnBuscarBusesRutasMasLargas;
        private Button btnBuscarBusesConMenosRutas;
        private TextBox tbBusConductor;
        private Label label1;
        private Button btnBuscarRutasPorConductorBus;
        private Button btnSalir;
    }
}