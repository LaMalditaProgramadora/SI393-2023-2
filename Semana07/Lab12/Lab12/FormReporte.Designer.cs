namespace Lab12
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
            tbEspecialidad = new TextBox();
            listViewDoctores = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listViewPacientes = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnBuscarDoctoresConPacientesConMayorEdad = new Button();
            btnBuscarDoctoresConMenosPacientes = new Button();
            btnBuscarPacientesPorEspecialidadDelDoctor = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 260);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 13;
            label3.Text = "Especialidad:";
            // 
            // tbEspecialidad
            // 
            tbEspecialidad.Location = new Point(104, 257);
            tbEspecialidad.Name = "tbEspecialidad";
            tbEspecialidad.Size = new Size(211, 23);
            tbEspecialidad.TabIndex = 12;
            // 
            // listViewDoctores
            // 
            listViewDoctores.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewDoctores.Location = new Point(336, 12);
            listViewDoctores.Name = "listViewDoctores";
            listViewDoctores.Size = new Size(419, 186);
            listViewDoctores.TabIndex = 11;
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
            // listViewPacientes
            // 
            listViewPacientes.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listViewPacientes.Location = new Point(336, 223);
            listViewPacientes.Name = "listViewPacientes";
            listViewPacientes.Size = new Size(419, 186);
            listViewPacientes.TabIndex = 14;
            listViewPacientes.UseCompatibleStateImageBehavior = false;
            listViewPacientes.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Dni";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nombre Completo";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Edad";
            columnHeader6.Width = 120;
            // 
            // btnBuscarDoctoresConPacientesConMayorEdad
            // 
            btnBuscarDoctoresConPacientesConMayorEdad.Location = new Point(23, 89);
            btnBuscarDoctoresConPacientesConMayorEdad.Name = "btnBuscarDoctoresConPacientesConMayorEdad";
            btnBuscarDoctoresConPacientesConMayorEdad.Size = new Size(292, 23);
            btnBuscarDoctoresConPacientesConMayorEdad.TabIndex = 15;
            btnBuscarDoctoresConPacientesConMayorEdad.Text = "Buscar Doctores con Pacientes con mayor edad";
            btnBuscarDoctoresConPacientesConMayorEdad.UseVisualStyleBackColor = true;
            btnBuscarDoctoresConPacientesConMayorEdad.Click += btnBuscarDoctoresConPacientesConMayorEdad_Click;
            // 
            // btnBuscarDoctoresConMenosPacientes
            // 
            btnBuscarDoctoresConMenosPacientes.Location = new Point(23, 118);
            btnBuscarDoctoresConMenosPacientes.Name = "btnBuscarDoctoresConMenosPacientes";
            btnBuscarDoctoresConMenosPacientes.Size = new Size(292, 23);
            btnBuscarDoctoresConMenosPacientes.TabIndex = 16;
            btnBuscarDoctoresConMenosPacientes.Text = "Buscar Doctores con Menos Pacientes";
            btnBuscarDoctoresConMenosPacientes.UseVisualStyleBackColor = true;
            btnBuscarDoctoresConMenosPacientes.Click += btnBuscarDoctoresConMenosPacientes_Click;
            // 
            // btnBuscarPacientesPorEspecialidadDelDoctor
            // 
            btnBuscarPacientesPorEspecialidadDelDoctor.Location = new Point(23, 296);
            btnBuscarPacientesPorEspecialidadDelDoctor.Name = "btnBuscarPacientesPorEspecialidadDelDoctor";
            btnBuscarPacientesPorEspecialidadDelDoctor.Size = new Size(292, 23);
            btnBuscarPacientesPorEspecialidadDelDoctor.TabIndex = 17;
            btnBuscarPacientesPorEspecialidadDelDoctor.Text = "Buscar Pacientes por Especialidad del Doctor";
            btnBuscarPacientesPorEspecialidadDelDoctor.UseVisualStyleBackColor = true;
            btnBuscarPacientesPorEspecialidadDelDoctor.Click += btnBuscarPacientesPorEspecialidadDelDoctor_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(135, 386);
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
            Controls.Add(btnBuscarPacientesPorEspecialidadDelDoctor);
            Controls.Add(btnBuscarDoctoresConMenosPacientes);
            Controls.Add(btnBuscarDoctoresConPacientesConMayorEdad);
            Controls.Add(listViewPacientes);
            Controls.Add(label3);
            Controls.Add(tbEspecialidad);
            Controls.Add(listViewDoctores);
            Name = "FormReporte";
            Text = "FormReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox tbEspecialidad;
        private ListView listViewDoctores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listViewPacientes;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnBuscarDoctoresConPacientesConMayorEdad;
        private Button btnBuscarDoctoresConMenosPacientes;
        private Button btnBuscarPacientesPorEspecialidadDelDoctor;
        private Button btnSalir;
    }
}