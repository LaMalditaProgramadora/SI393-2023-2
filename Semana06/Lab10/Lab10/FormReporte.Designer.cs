namespace Lab10
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
            label3 = new Label();
            tbConductor = new TextBox();
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
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 255);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 13;
            label3.Text = "Conductor:";
            // 
            // tbConductor
            // 
            tbConductor.Location = new Point(96, 252);
            tbConductor.Name = "tbConductor";
            tbConductor.Size = new Size(193, 23);
            tbConductor.TabIndex = 12;
            // 
            // listViewBuses
            // 
            listViewBuses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewBuses.Location = new Point(315, 12);
            listViewBuses.Name = "listViewBuses";
            listViewBuses.Size = new Size(308, 186);
            listViewBuses.TabIndex = 11;
            listViewBuses.UseCompatibleStateImageBehavior = false;
            listViewBuses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Matrícula";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Conductor";
            columnHeader3.Width = 100;
            // 
            // listViewRutas
            // 
            listViewRutas.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewRutas.Location = new Point(315, 223);
            listViewRutas.Name = "listViewRutas";
            listViewRutas.Size = new Size(419, 186);
            listViewRutas.TabIndex = 14;
            listViewRutas.UseCompatibleStateImageBehavior = false;
            listViewRutas.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Código";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Origen";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Destino";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kilómetros";
            columnHeader7.Width = 100;
            // 
            // btnBuscarBusesConRutasMasLargas
            // 
            btnBuscarBusesConRutasMasLargas.Location = new Point(23, 89);
            btnBuscarBusesConRutasMasLargas.Name = "btnBuscarBusesConRutasMasLargas";
            btnBuscarBusesConRutasMasLargas.Size = new Size(266, 23);
            btnBuscarBusesConRutasMasLargas.TabIndex = 15;
            btnBuscarBusesConRutasMasLargas.Text = "Buscar Buses con Rutas más Largas";
            btnBuscarBusesConRutasMasLargas.UseVisualStyleBackColor = true;
            btnBuscarBusesConRutasMasLargas.Click += btnBuscarBusesConRutasMasLargas_Click;
            // 
            // btnBuscarBusesConMenosRutas
            // 
            btnBuscarBusesConMenosRutas.Location = new Point(23, 118);
            btnBuscarBusesConMenosRutas.Name = "btnBuscarBusesConMenosRutas";
            btnBuscarBusesConMenosRutas.Size = new Size(266, 23);
            btnBuscarBusesConMenosRutas.TabIndex = 16;
            btnBuscarBusesConMenosRutas.Text = "Buscar Buses con Menos Rutas";
            btnBuscarBusesConMenosRutas.UseVisualStyleBackColor = true;
            btnBuscarBusesConMenosRutas.Click += btnBuscarBusesConMenosRutas_Click;
            // 
            // btnBuscarRutasPorConductorBus
            // 
            btnBuscarRutasPorConductorBus.Location = new Point(23, 296);
            btnBuscarRutasPorConductorBus.Name = "btnBuscarRutasPorConductorBus";
            btnBuscarRutasPorConductorBus.Size = new Size(266, 23);
            btnBuscarRutasPorConductorBus.TabIndex = 17;
            btnBuscarRutasPorConductorBus.Text = "Buscar Rutas por Conductor de Bus";
            btnBuscarRutasPorConductorBus.UseVisualStyleBackColor = true;
            btnBuscarRutasPorConductorBus.Click += btnBuscarRutasPorConductorBus_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(119, 386);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscarRutasPorConductorBus);
            Controls.Add(btnBuscarBusesConMenosRutas);
            Controls.Add(btnBuscarBusesConRutasMasLargas);
            Controls.Add(listViewRutas);
            Controls.Add(label3);
            Controls.Add(tbConductor);
            Controls.Add(listViewBuses);
            Name = "FormReporte";
            Text = "FormReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox tbConductor;
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
        private Button btnSalir;
    }
}