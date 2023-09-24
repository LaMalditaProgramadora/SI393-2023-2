namespace Lab10
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
            btnRegistrar = new Button();
            btnVerRutas = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            listViewBuses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tbMatricula = new TextBox();
            tbConductor = new TextBox();
            cbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(143, 131);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerRutas
            // 
            btnVerRutas.Location = new Point(143, 160);
            btnVerRutas.Name = "btnVerRutas";
            btnVerRutas.Size = new Size(75, 23);
            btnVerRutas.TabIndex = 1;
            btnVerRutas.Text = "Ver Rutas";
            btnVerRutas.UseVisualStyleBackColor = true;
            btnVerRutas.Click += btnVerRutas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(143, 189);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(75, 23);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(143, 218);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listViewBuses
            // 
            listViewBuses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewBuses.Location = new Point(333, 12);
            listViewBuses.Name = "listViewBuses";
            listViewBuses.Size = new Size(308, 258);
            listViewBuses.TabIndex = 4;
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
            // tbMatricula
            // 
            tbMatricula.Location = new Point(98, 26);
            tbMatricula.Name = "tbMatricula";
            tbMatricula.Size = new Size(193, 23);
            tbMatricula.TabIndex = 5;
            // 
            // tbConductor
            // 
            tbConductor.Location = new Point(98, 84);
            tbConductor.Name = "tbConductor";
            tbConductor.Size = new Size(193, 23);
            tbConductor.TabIndex = 6;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Tipo 1", "Tipo 2" });
            cbTipo.Location = new Point(98, 55);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(193, 23);
            cbTipo.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Matrícula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 58);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Conductor:";
            // 
            // FormBus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 284);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTipo);
            Controls.Add(tbConductor);
            Controls.Add(tbMatricula);
            Controls.Add(listViewBuses);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnVerRutas);
            Controls.Add(btnRegistrar);
            Name = "FormBus";
            Text = "FormBus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnVerRutas;
        private Button btnReportes;
        private Button btnSalir;
        private ListView listViewBuses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox tbMatricula;
        private TextBox tbConductor;
        private ComboBox cbTipo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}