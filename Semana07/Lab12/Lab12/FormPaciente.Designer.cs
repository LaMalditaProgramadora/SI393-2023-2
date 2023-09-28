using static System.Net.Mime.MediaTypeNames;

namespace Lab12
{
    partial class FormPaciente
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
            tbDni = new TextBox();
            tbNombreCompleto = new TextBox();
            tbEdad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            listViewPacientes = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // tbDni
            // 
            tbDni.Location = new Point(142, 25);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(164, 23);
            tbDni.TabIndex = 0;
            // 
            // tbNombreCompleto
            // 
            tbNombreCompleto.Location = new Point(142, 54);
            tbNombreCompleto.Name = "tbNombreCompleto";
            tbNombreCompleto.Size = new Size(164, 23);
            tbNombreCompleto.TabIndex = 1;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(142, 83);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(164, 23);
            tbEdad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 28);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Dni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 57);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 86);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Edad:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(119, 163);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(119, 192);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listViewPacientes
            // 
            listViewPacientes.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listViewPacientes.Location = new Point(351, 25);
            listViewPacientes.Name = "listViewPacientes";
            listViewPacientes.Size = new Size(419, 190);
            listViewPacientes.TabIndex = 15;
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
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 242);
            Controls.Add(listViewPacientes);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEdad);
            Controls.Add(tbNombreCompleto);
            Controls.Add(tbDni);
            Name = "FormPaciente";
            Text = "FormPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDni;
        private TextBox tbNombreCompleto;
        private TextBox tbEdad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegistrar;
        private Button btnSalir;
        private ListView listViewPacientes;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}