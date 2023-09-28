namespace Lab12
{
    partial class FormDoctor
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
            btnVerPacientes = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            tbNroColegiatura = new TextBox();
            tbEspecialidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listViewDoctores = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tbNombreCompleto = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(132, 131);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(102, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerPacientes
            // 
            btnVerPacientes.Location = new Point(132, 160);
            btnVerPacientes.Name = "btnVerPacientes";
            btnVerPacientes.Size = new Size(102, 23);
            btnVerPacientes.TabIndex = 1;
            btnVerPacientes.Text = "Ver Pacientes";
            btnVerPacientes.UseVisualStyleBackColor = true;
            btnVerPacientes.Click += btnVerPacientes_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(132, 189);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(102, 23);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(132, 218);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tbNroColegiatura
            // 
            tbNroColegiatura.Location = new Point(143, 26);
            tbNroColegiatura.Name = "tbNroColegiatura";
            tbNroColegiatura.Size = new Size(193, 23);
            tbNroColegiatura.TabIndex = 5;
            // 
            // tbEspecialidad
            // 
            tbEspecialidad.Location = new Point(143, 84);
            tbEspecialidad.Name = "tbEspecialidad";
            tbEspecialidad.Size = new Size(193, 23);
            tbEspecialidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 8;
            label1.Text = "Nro. Colegiatura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 58);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 87);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 10;
            label3.Text = "Especialidad:";
            // 
            // listViewDoctores
            // 
            listViewDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewDoctores.Location = new Point(380, 26);
            listViewDoctores.Name = "listViewDoctores";
            listViewDoctores.Size = new Size(400, 215);
            listViewDoctores.TabIndex = 12;
            listViewDoctores.UseCompatibleStateImageBehavior = false;
            listViewDoctores.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Colegiatura";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre Completo";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Especialidad";
            columnHeader3.Width = 120;
            // 
            // tbNombreCompleto
            // 
            tbNombreCompleto.Location = new Point(142, 55);
            tbNombreCompleto.Name = "tbNombreCompleto";
            tbNombreCompleto.Size = new Size(194, 23);
            tbNombreCompleto.TabIndex = 13;
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 266);
            Controls.Add(tbNombreCompleto);
            Controls.Add(listViewDoctores);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEspecialidad);
            Controls.Add(tbNroColegiatura);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnVerPacientes);
            Controls.Add(btnRegistrar);
            Name = "FormDoctor";
            Text = "FormDoctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnVerPacientes;
        private Button btnReportes;
        private Button btnSalir;
        private TextBox tbNroColegiatura;
        private TextBox tbEspecialidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listViewDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox tbNombreCompleto;
    }
}