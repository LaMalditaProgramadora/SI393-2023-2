namespace Lab13
{
    partial class FormVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbNumTarjetaProp = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbNumMotor = new System.Windows.Forms.TextBox();
            this.tbFechaUltimIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerOrdenes = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listViewVehiculos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Núm. Tarjeta Propiedad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Núm. Motor:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(146, 18);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(143, 20);
            this.tbPlaca.TabIndex = 5;
            // 
            // tbNumTarjetaProp
            // 
            this.tbNumTarjetaProp.Location = new System.Drawing.Point(146, 44);
            this.tbNumTarjetaProp.Name = "tbNumTarjetaProp";
            this.tbNumTarjetaProp.Size = new System.Drawing.Size(143, 20);
            this.tbNumTarjetaProp.TabIndex = 6;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(146, 70);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(143, 20);
            this.tbModelo.TabIndex = 7;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(146, 96);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(143, 20);
            this.tbColor.TabIndex = 8;
            // 
            // tbNumMotor
            // 
            this.tbNumMotor.Location = new System.Drawing.Point(146, 122);
            this.tbNumMotor.Name = "tbNumMotor";
            this.tbNumMotor.Size = new System.Drawing.Size(143, 20);
            this.tbNumMotor.TabIndex = 9;
            // 
            // tbFechaUltimIngreso
            // 
            this.tbFechaUltimIngreso.Location = new System.Drawing.Point(146, 148);
            this.tbFechaUltimIngreso.Name = "tbFechaUltimIngreso";
            this.tbFechaUltimIngreso.Size = new System.Drawing.Size(143, 20);
            this.tbFechaUltimIngreso.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Último Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nota: El formato de fecha debe ser YYYYMMDD";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(89, 241);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 23);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerOrdenes
            // 
            this.btnVerOrdenes.Location = new System.Drawing.Point(89, 270);
            this.btnVerOrdenes.Name = "btnVerOrdenes";
            this.btnVerOrdenes.Size = new System.Drawing.Size(147, 23);
            this.btnVerOrdenes.TabIndex = 14;
            this.btnVerOrdenes.Text = "Ver Órdenes";
            this.btnVerOrdenes.UseVisualStyleBackColor = true;
            this.btnVerOrdenes.Click += new System.EventHandler(this.btnVerOrdenes_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Location = new System.Drawing.Point(89, 299);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(147, 23);
            this.btnVerReportes.TabIndex = 15;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(89, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listViewVehiculos
            // 
            this.listViewVehiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewVehiculos.HideSelection = false;
            this.listViewVehiculos.Location = new System.Drawing.Point(331, 18);
            this.listViewVehiculos.Name = "listViewVehiculos";
            this.listViewVehiculos.Size = new System.Drawing.Size(530, 333);
            this.listViewVehiculos.TabIndex = 17;
            this.listViewVehiculos.UseCompatibleStateImageBehavior = false;
            this.listViewVehiculos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Núm. Tarjeta Propiedad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modelo";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Color";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Núm. Motor";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha Último Ingreso";
            this.columnHeader6.Width = 100;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 369);
            this.Controls.Add(this.listViewVehiculos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.btnVerOrdenes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFechaUltimIngreso);
            this.Controls.Add(this.tbNumMotor);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbNumTarjetaProp);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVehiculo";
            this.Text = "FormVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.TextBox tbNumTarjetaProp;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbNumMotor;
        private System.Windows.Forms.TextBox tbFechaUltimIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerOrdenes;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView listViewVehiculos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}