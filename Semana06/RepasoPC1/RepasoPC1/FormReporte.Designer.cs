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
            listViewBuses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listViewRutas = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnBuscarBusesConRutasMasLargas = new Button();
            btnBuscarBusesConMenosRutas = new Button();
            btnBuscarRutasPorConductorBus = new Button();
            tbConductor = new TextBox();
            label1 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // listViewBuses
            // 
            listViewBuses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewBuses.Location = new Point(275, 23);
            listViewBuses.Name = "listViewBuses";
            listViewBuses.Size = new Size(419, 222);
            listViewBuses.TabIndex = 12;
            listViewBuses.UseCompatibleStateImageBehavior = false;
            listViewBuses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Matrícula";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Conductor";
            // 
            // listViewRutas
            // 
            listViewRutas.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewRutas.Location = new Point(275, 260);
            listViewRutas.Name = "listViewRutas";
            listViewRutas.Size = new Size(419, 216);
            listViewRutas.TabIndex = 13;
            listViewRutas.UseCompatibleStateImageBehavior = false;
            listViewRutas.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Código";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Origen";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Destino";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kilómetros";
            // 
            // btnBuscarBusesConRutasMasLargas
            // 
            btnBuscarBusesConRutasMasLargas.Location = new Point(36, 47);
            btnBuscarBusesConRutasMasLargas.Name = "btnBuscarBusesConRutasMasLargas";
            btnBuscarBusesConRutasMasLargas.Size = new Size(169, 46);
            btnBuscarBusesConRutasMasLargas.TabIndex = 14;
            btnBuscarBusesConRutasMasLargas.Text = "Buscar Buses con Rutas más Largas";
            btnBuscarBusesConRutasMasLargas.UseVisualStyleBackColor = true;
            btnBuscarBusesConRutasMasLargas.Click += btnBuscarBusesConRutasMasLargas_Click;
            // 
            // btnBuscarBusesConMenosRutas
            // 
            btnBuscarBusesConMenosRutas.Location = new Point(36, 99);
            btnBuscarBusesConMenosRutas.Name = "btnBuscarBusesConMenosRutas";
            btnBuscarBusesConMenosRutas.Size = new Size(169, 46);
            btnBuscarBusesConMenosRutas.TabIndex = 15;
            btnBuscarBusesConMenosRutas.Text = "Buscar Buses con Menos Rutas";
            btnBuscarBusesConMenosRutas.UseVisualStyleBackColor = true;
            btnBuscarBusesConMenosRutas.Click += btnBuscarBusesConMenosRutas_Click;
            // 
            // btnBuscarRutasPorConductorBus
            // 
            btnBuscarRutasPorConductorBus.Location = new Point(36, 347);
            btnBuscarRutasPorConductorBus.Name = "btnBuscarRutasPorConductorBus";
            btnBuscarRutasPorConductorBus.Size = new Size(169, 46);
            btnBuscarRutasPorConductorBus.TabIndex = 16;
            btnBuscarRutasPorConductorBus.Text = "Buscar Rutas por Conductor de Bus";
            btnBuscarRutasPorConductorBus.UseVisualStyleBackColor = true;
            btnBuscarRutasPorConductorBus.Click += btnBuscarRutasPorConductorBus_Click;
            // 
            // tbConductor
            // 
            tbConductor.Location = new Point(36, 318);
            tbConductor.Name = "tbConductor";
            tbConductor.Size = new Size(169, 23);
            tbConductor.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 300);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 18;
            label1.Text = "Conductor:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(84, 453);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 519);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(tbConductor);
            Controls.Add(btnBuscarRutasPorConductorBus);
            Controls.Add(btnBuscarBusesConMenosRutas);
            Controls.Add(btnBuscarBusesConRutasMasLargas);
            Controls.Add(listViewRutas);
            Controls.Add(listViewBuses);
            Name = "FormReporte";
            Text = "FormReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewBuses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listViewRutas;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnBuscarBusesConRutasMasLargas;
        private Button btnBuscarBusesConMenosRutas;
        private Button btnBuscarRutasPorConductorBus;
        private TextBox tbConductor;
        private Label label1;
        private Button btnSalir;
    }
}