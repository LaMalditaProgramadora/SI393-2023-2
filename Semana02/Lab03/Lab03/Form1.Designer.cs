namespace Lab03
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
            buttonRegistrar = new Button();
            buttonMostrar = new Button();
            comboBoxTipoAuto = new ComboBox();
            comboBoxTipoServicio = new ComboBox();
            listViewAtenciones = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            labelServicioMinimaDemanda = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelTotalServicio1 = new Label();
            labelTotalServicio2 = new Label();
            labelTotalServicio3 = new Label();
            labelMontoPromedio = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "TIPO AUTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 19);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "TIPO SERVICIO:";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Location = new Point(12, 68);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(75, 23);
            buttonRegistrar.TabIndex = 2;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.Location = new Point(93, 68);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(75, 23);
            buttonMostrar.TabIndex = 3;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // comboBoxTipoAuto
            // 
            comboBoxTipoAuto.FormattingEnabled = true;
            comboBoxTipoAuto.Items.AddRange(new object[] { "A", "C" });
            comboBoxTipoAuto.Location = new Point(93, 16);
            comboBoxTipoAuto.Name = "comboBoxTipoAuto";
            comboBoxTipoAuto.Size = new Size(121, 23);
            comboBoxTipoAuto.TabIndex = 4;
            // 
            // comboBoxTipoServicio
            // 
            comboBoxTipoServicio.FormattingEnabled = true;
            comboBoxTipoServicio.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxTipoServicio.Location = new Point(448, 16);
            comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            comboBoxTipoServicio.Size = new Size(121, 23);
            comboBoxTipoServicio.TabIndex = 5;
            // 
            // listViewAtenciones
            // 
            listViewAtenciones.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewAtenciones.Location = new Point(12, 120);
            listViewAtenciones.Name = "listViewAtenciones";
            listViewAtenciones.Size = new Size(754, 129);
            listViewAtenciones.TabIndex = 6;
            listViewAtenciones.UseCompatibleStateImageBehavior = false;
            listViewAtenciones.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tipo Auto";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo Servicio";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Monto";
            // 
            // labelServicioMinimaDemanda
            // 
            labelServicioMinimaDemanda.AutoSize = true;
            labelServicioMinimaDemanda.Location = new Point(622, 286);
            labelServicioMinimaDemanda.Name = "labelServicioMinimaDemanda";
            labelServicioMinimaDemanda.Size = new Size(12, 15);
            labelServicioMinimaDemanda.TabIndex = 7;
            labelServicioMinimaDemanda.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 286);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 8;
            label4.Text = "TOTAL SERVICIO 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 320);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 9;
            label5.Text = "TOTAL SERVICIO 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 352);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 10;
            label6.Text = "TOTAL SERVICIO 3:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 286);
            label7.Name = "label7";
            label7.Size = new Size(168, 15);
            label7.TabIndex = 11;
            label7.Text = "SERVICIO MÍNIMA DEMANDA:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(500, 320);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 12;
            label8.Text = "MONTO PROMEDIO:";
            // 
            // labelTotalServicio1
            // 
            labelTotalServicio1.AutoSize = true;
            labelTotalServicio1.Location = new Point(138, 286);
            labelTotalServicio1.Name = "labelTotalServicio1";
            labelTotalServicio1.Size = new Size(13, 15);
            labelTotalServicio1.TabIndex = 13;
            labelTotalServicio1.Text = "0";
            // 
            // labelTotalServicio2
            // 
            labelTotalServicio2.AutoSize = true;
            labelTotalServicio2.Location = new Point(138, 320);
            labelTotalServicio2.Name = "labelTotalServicio2";
            labelTotalServicio2.Size = new Size(13, 15);
            labelTotalServicio2.TabIndex = 14;
            labelTotalServicio2.Text = "0";
            // 
            // labelTotalServicio3
            // 
            labelTotalServicio3.AutoSize = true;
            labelTotalServicio3.Location = new Point(138, 352);
            labelTotalServicio3.Name = "labelTotalServicio3";
            labelTotalServicio3.Size = new Size(13, 15);
            labelTotalServicio3.TabIndex = 15;
            labelTotalServicio3.Text = "0";
            // 
            // labelMontoPromedio
            // 
            labelMontoPromedio.AutoSize = true;
            labelMontoPromedio.Location = new Point(622, 320);
            labelMontoPromedio.Name = "labelMontoPromedio";
            labelMontoPromedio.Size = new Size(13, 15);
            labelMontoPromedio.TabIndex = 16;
            labelMontoPromedio.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 404);
            Controls.Add(labelMontoPromedio);
            Controls.Add(labelTotalServicio3);
            Controls.Add(labelTotalServicio2);
            Controls.Add(labelTotalServicio1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelServicioMinimaDemanda);
            Controls.Add(listViewAtenciones);
            Controls.Add(comboBoxTipoServicio);
            Controls.Add(comboBoxTipoAuto);
            Controls.Add(buttonMostrar);
            Controls.Add(buttonRegistrar);
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
        private Button buttonRegistrar;
        private Button buttonMostrar;
        private ComboBox comboBoxTipoAuto;
        private ComboBox comboBoxTipoServicio;
        private ListView listViewAtenciones;
        private Label labelServicioMinimaDemanda;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelTotalServicio1;
        private Label labelTotalServicio2;
        private Label labelTotalServicio3;
        private Label labelMontoPromedio;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}