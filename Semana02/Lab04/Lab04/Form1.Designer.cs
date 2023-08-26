namespace Lab04
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonInsertar = new Button();
            buttonMostrar = new Button();
            buttonEliminar = new Button();
            buttonOrdenar = new Button();
            buttonBuscar = new Button();
            textBoxCodigo = new TextBox();
            textBoxNombre = new TextBox();
            textBoxPromedio = new TextBox();
            textBoxBusqueda = new TextBox();
            listViewAlumnos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 47);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 75);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "PROMEDIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 156);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 3;
            label4.Text = "BUSCAR POR CÓDIGO:";
            // 
            // buttonInsertar
            // 
            buttonInsertar.Location = new Point(30, 113);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(75, 23);
            buttonInsertar.TabIndex = 4;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.Location = new Point(111, 113);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(75, 23);
            buttonMostrar.TabIndex = 5;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(192, 113);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.Location = new Point(273, 113);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(75, 23);
            buttonOrdenar.TabIndex = 7;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = true;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(375, 148);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 8;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(123, 15);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(225, 23);
            textBoxCodigo.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(123, 44);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(346, 23);
            textBoxNombre.TabIndex = 10;
            // 
            // textBoxPromedio
            // 
            textBoxPromedio.Location = new Point(123, 73);
            textBoxPromedio.Name = "textBoxPromedio";
            textBoxPromedio.Size = new Size(100, 23);
            textBoxPromedio.TabIndex = 11;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(167, 149);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(181, 23);
            textBoxBusqueda.TabIndex = 12;
            // 
            // listViewAlumnos
            // 
            listViewAlumnos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewAlumnos.Location = new Point(30, 204);
            listViewAlumnos.Name = "listViewAlumnos";
            listViewAlumnos.Size = new Size(708, 206);
            listViewAlumnos.TabIndex = 13;
            listViewAlumnos.UseCompatibleStateImageBehavior = false;
            listViewAlumnos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Promedio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewAlumnos);
            Controls.Add(textBoxBusqueda);
            Controls.Add(textBoxPromedio);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxCodigo);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonOrdenar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonMostrar);
            Controls.Add(buttonInsertar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonInsertar;
        private Button buttonMostrar;
        private Button buttonEliminar;
        private Button buttonOrdenar;
        private Button buttonBuscar;
        private TextBox textBoxCodigo;
        private TextBox textBoxNombre;
        private TextBox textBoxPromedio;
        private TextBox textBoxBusqueda;
        private ListView listViewAlumnos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}