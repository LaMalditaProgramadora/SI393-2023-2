namespace Lab07
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
            textBoxCodigo = new TextBox();
            textBoxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listViewAlumnos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxEdad = new TextBox();
            textBoxDni = new TextBox();
            SuspendLayout();
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(87, 35);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(187, 23);
            textBoxCodigo.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(367, 35);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(187, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 38);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // listViewAlumnos
            // 
            listViewAlumnos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewAlumnos.Location = new Point(32, 159);
            listViewAlumnos.Name = "listViewAlumnos";
            listViewAlumnos.Size = new Size(522, 219);
            listViewAlumnos.TabIndex = 4;
            listViewAlumnos.UseCompatibleStateImageBehavior = false;
            listViewAlumnos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DNI";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Edad";
            columnHeader4.Width = 80;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(32, 114);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 5;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(113, 114);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 67);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 67);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 9;
            label4.Text = "DNI:";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(367, 64);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(187, 23);
            textBoxEdad.TabIndex = 8;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(87, 64);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(187, 23);
            textBoxDni.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 411);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxDni);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(listViewAlumnos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxCodigo);
            Name = "Form1";
            Text = "Formulario Alumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCodigo;
        private TextBox textBoxNombre;
        private Label label1;
        private Label label2;
        private ListView listViewAlumnos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Label label3;
        private Label label4;
        private TextBox textBoxEdad;
        private TextBox textBoxDni;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}