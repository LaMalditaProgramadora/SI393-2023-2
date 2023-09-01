namespace Lab05
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
            label4 = new Label();
            label5 = new Label();
            textBoxCodigo = new TextBox();
            textBoxNombre = new TextBox();
            numericUpDownStock = new NumericUpDown();
            textBoxPrecio = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonRegistrar = new Button();
            buttonEliminar = new Button();
            buttonEliminarTodo = new Button();
            textBoxBusqueda = new TextBox();
            label6 = new Label();
            listViewElectrodomesticos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label7 = new Label();
            labelTotalRegistros = new Label();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            labelTotalStock = new Label();
            label8 = new Label();
            buttonOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 56);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "STOCK:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 56);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "PRECIO:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(86, 10);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(174, 23);
            textBoxCodigo.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(393, 10);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(347, 23);
            textBoxNombre.TabIndex = 6;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(86, 48);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 8;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(393, 48);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(150, 23);
            textBoxPrecio.TabIndex = 9;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Location = new Point(25, 101);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(75, 23);
            buttonRegistrar.TabIndex = 10;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(106, 101);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 11;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEliminarTodo
            // 
            buttonEliminarTodo.Location = new Point(187, 101);
            buttonEliminarTodo.Name = "buttonEliminarTodo";
            buttonEliminarTodo.Size = new Size(100, 23);
            buttonEliminarTodo.TabIndex = 12;
            buttonEliminarTodo.Text = "Eliminar Todo";
            buttonEliminarTodo.UseVisualStyleBackColor = true;
            buttonEliminarTodo.Click += buttonEliminarTodo_Click;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(163, 142);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(274, 23);
            textBoxBusqueda.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 149);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 14;
            label6.Text = "BUSCAR POR NOMBRE:";
            // 
            // listViewElectrodomesticos
            // 
            listViewElectrodomesticos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewElectrodomesticos.Location = new Point(25, 190);
            listViewElectrodomesticos.Name = "listViewElectrodomesticos";
            listViewElectrodomesticos.Size = new Size(715, 169);
            listViewElectrodomesticos.TabIndex = 15;
            listViewElectrodomesticos.UseCompatibleStateImageBehavior = false;
            listViewElectrodomesticos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Stock";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio";
            columnHeader4.Width = 90;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(569, 378);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 16;
            label7.Text = "TOTAL DE REGISTROS:";
            // 
            // labelTotalRegistros
            // 
            labelTotalRegistros.AutoSize = true;
            labelTotalRegistros.Location = new Point(695, 378);
            labelTotalRegistros.Name = "labelTotalRegistros";
            labelTotalRegistros.Size = new Size(13, 15);
            labelTotalRegistros.TabIndex = 17;
            labelTotalRegistros.Text = "0";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(468, 141);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 18;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(549, 142);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 19;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // labelTotalStock
            // 
            labelTotalStock.AutoSize = true;
            labelTotalStock.Location = new Point(695, 407);
            labelTotalStock.Name = "labelTotalStock";
            labelTotalStock.Size = new Size(13, 15);
            labelTotalStock.TabIndex = 21;
            labelTotalStock.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(591, 407);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 20;
            label8.Text = "TOTAL EN STOCK:";
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.Location = new Point(293, 101);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(75, 23);
            buttonOrdenar.TabIndex = 22;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = true;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 461);
            Controls.Add(buttonOrdenar);
            Controls.Add(labelTotalStock);
            Controls.Add(label8);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(labelTotalRegistros);
            Controls.Add(label7);
            Controls.Add(listViewElectrodomesticos);
            Controls.Add(label6);
            Controls.Add(textBoxBusqueda);
            Controls.Add(buttonEliminarTodo);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonRegistrar);
            Controls.Add(textBoxPrecio);
            Controls.Add(numericUpDownStock);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBoxCodigo;
        private TextBox textBoxNombre;
        private NumericUpDown numericUpDownStock;
        private TextBox textBoxPrecio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonRegistrar;
        private Button buttonEliminar;
        private Button buttonEliminarTodo;
        private TextBox textBoxBusqueda;
        private Label label6;
        private ListView listViewElectrodomesticos;
        private Label label7;
        private Label labelTotalRegistros;
        private Button buttonBuscar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttonLimpiar;
        private Label labelTotalStock;
        private Label label8;
        private Button buttonOrdenar;
    }
}