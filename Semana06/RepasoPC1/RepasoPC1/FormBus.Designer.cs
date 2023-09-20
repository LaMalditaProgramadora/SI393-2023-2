namespace RepasoPC1
{
    partial class FormBus
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
            tbMatricula = new TextBox();
            tbTipo = new TextBox();
            tbConductor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            btnVerRutas = new Button();
            btnReporte = new Button();
            btnSalir = new Button();
            listViewBuses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // tbMatricula
            // 
            tbMatricula.Location = new Point(99, 35);
            tbMatricula.Name = "tbMatricula";
            tbMatricula.Size = new Size(152, 23);
            tbMatricula.TabIndex = 1;
            // 
            // tbTipo
            // 
            tbTipo.Location = new Point(99, 64);
            tbTipo.Name = "tbTipo";
            tbTipo.Size = new Size(152, 23);
            tbTipo.TabIndex = 2;
            // 
            // tbConductor
            // 
            tbConductor.Location = new Point(99, 93);
            tbConductor.Name = "tbConductor";
            tbConductor.Size = new Size(152, 23);
            tbConductor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Matrícula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 67);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 96);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Conductor:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(107, 146);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerRutas
            // 
            btnVerRutas.Location = new Point(107, 175);
            btnVerRutas.Name = "btnVerRutas";
            btnVerRutas.Size = new Size(75, 23);
            btnVerRutas.TabIndex = 8;
            btnVerRutas.Text = "Ver Rutas";
            btnVerRutas.UseVisualStyleBackColor = true;
            btnVerRutas.Click += btnVerRutas_Click;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(107, 204);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(75, 23);
            btnReporte.TabIndex = 9;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(107, 233);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listViewBuses
            // 
            listViewBuses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewBuses.Location = new Point(318, 35);
            listViewBuses.Name = "listViewBuses";
            listViewBuses.Size = new Size(414, 254);
            listViewBuses.TabIndex = 11;
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
            // FormBus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 350);
            Controls.Add(listViewBuses);
            Controls.Add(btnSalir);
            Controls.Add(btnReporte);
            Controls.Add(btnVerRutas);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbConductor);
            Controls.Add(tbTipo);
            Controls.Add(tbMatricula);
            Name = "FormBus";
            Text = "Buses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbMatricula;
        private TextBox tbTipo;
        private TextBox tbConductor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegistrar;
        private Button btnVerRutas;
        private Button btnReporte;
        private Button btnSalir;
        private ListView listViewBuses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}