namespace pjEmpresa
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
            comboBoxCategoria = new ComboBox();
            textBoxNombre = new TextBox();
            textBoxMinutosTardanza = new TextBox();
            textBoxLlamadasAtencion = new TextBox();
            listViewEmpleados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 64);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "CATEGORIA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 108);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 2;
            label3.Text = "MINUTOS TARDANZA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 108);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 3;
            label4.Text = "LLAMADAS ATENCIÓN:";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "A", "B", "C", "D" });
            comboBoxCategoria.Location = new Point(151, 61);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(121, 23);
            comboBoxCategoria.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(151, 21);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(354, 23);
            textBoxNombre.TabIndex = 5;
            // 
            // textBoxMinutosTardanza
            // 
            textBoxMinutosTardanza.Location = new Point(205, 105);
            textBoxMinutosTardanza.Name = "textBoxMinutosTardanza";
            textBoxMinutosTardanza.Size = new Size(100, 23);
            textBoxMinutosTardanza.TabIndex = 6;
            // 
            // textBoxLlamadasAtencion
            // 
            textBoxLlamadasAtencion.Location = new Point(579, 105);
            textBoxLlamadasAtencion.Name = "textBoxLlamadasAtencion";
            textBoxLlamadasAtencion.Size = new Size(100, 23);
            textBoxLlamadasAtencion.TabIndex = 7;
            // 
            // listViewEmpleados
            // 
            listViewEmpleados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewEmpleados.Location = new Point(67, 245);
            listViewEmpleados.Name = "listViewEmpleados";
            listViewEmpleados.Size = new Size(659, 115);
            listViewEmpleados.TabIndex = 8;
            listViewEmpleados.UseCompatibleStateImageBehavior = false;
            listViewEmpleados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Categoría";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Minutos tardanza";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Llamadas atención";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 391);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "TOTAL:";
            // 
            // button1
            // 
            button1.Location = new Point(170, 169);
            button1.Name = "button1";
            button1.Size = new Size(161, 39);
            button1.TabIndex = 10;
            button1.Text = "REGISTRAR EMPLEADO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(465, 169);
            button2.Name = "button2";
            button2.Size = new Size(139, 39);
            button2.TabIndex = 11;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(591, 391);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(13, 15);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(listViewEmpleados);
            Controls.Add(textBoxLlamadasAtencion);
            Controls.Add(textBoxMinutosTardanza);
            Controls.Add(textBoxNombre);
            Controls.Add(comboBoxCategoria);
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
        private ComboBox comboBoxCategoria;
        private TextBox textBoxNombre;
        private TextBox textBoxMinutosTardanza;
        private TextBox textBoxLlamadasAtencion;
        private ListView listViewEmpleados;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label labelTotal;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}