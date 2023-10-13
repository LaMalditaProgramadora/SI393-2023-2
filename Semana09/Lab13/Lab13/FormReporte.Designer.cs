namespace Lab13
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNombreServicio = new System.Windows.Forms.ComboBox();
            this.listViewVehiculos = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años = new System.Windows.Forms.Button();
            this.btnOrdenarVehiculosAscPlaca = new System.Windows.Forms.Button();
            this.btnBuscarVehiculosMayorMontoPorNombreServicio = new System.Windows.Forms.Button();
            this.btnBuscarVehiculosMenosOrdenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(28, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(257, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre del Servicio:";
            // 
            // cbNombreServicio
            // 
            this.cbNombreServicio.FormattingEnabled = true;
            this.cbNombreServicio.Items.AddRange(new object[] {
            "Mantenimiento de Frenos",
            "Mantenimiento de Motor",
            "Mantenimiento de Dirección",
            "Cambio de Aceite"});
            this.cbNombreServicio.Location = new System.Drawing.Point(136, 137);
            this.cbNombreServicio.Name = "cbNombreServicio";
            this.cbNombreServicio.Size = new System.Drawing.Size(149, 21);
            this.cbNombreServicio.TabIndex = 22;
            // 
            // listViewVehiculos
            // 
            this.listViewVehiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewVehiculos.HideSelection = false;
            this.listViewVehiculos.Location = new System.Drawing.Point(328, 21);
            this.listViewVehiculos.Name = "listViewVehiculos";
            this.listViewVehiculos.Size = new System.Drawing.Size(530, 278);
            this.listViewVehiculos.TabIndex = 26;
            this.listViewVehiculos.UseCompatibleStateImageBehavior = false;
            this.listViewVehiculos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Placa";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Núm. Tarjeta Propiedad";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Modelo";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Color";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Núm. Motor";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Fecha Último Ingreso";
            this.columnHeader11.Width = 100;
            // 
            // btnBuscarVehiculosMasOrdenesEnUltimos2Años
            // 
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años.Location = new System.Drawing.Point(25, 21);
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años.Name = "btnBuscarVehiculosMasOrdenesEnUltimos2Años";
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años.Size = new System.Drawing.Size(260, 43);
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años.TabIndex = 27;
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años.Text = "Buscar Vehículos con mayor número de órdenes en los últimos dos años";
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculosMasOrdenesEnUltimos2Años.Click += new System.EventHandler(this.btnBuscarVehiculosMasOrdenesEnUltimos2Años_Click);
            // 
            // btnOrdenarVehiculosAscPlaca
            // 
            this.btnOrdenarVehiculosAscPlaca.Location = new System.Drawing.Point(25, 70);
            this.btnOrdenarVehiculosAscPlaca.Name = "btnOrdenarVehiculosAscPlaca";
            this.btnOrdenarVehiculosAscPlaca.Size = new System.Drawing.Size(260, 43);
            this.btnOrdenarVehiculosAscPlaca.TabIndex = 28;
            this.btnOrdenarVehiculosAscPlaca.Text = "Ordenar Vehículos de forma ascendente por número de placa";
            this.btnOrdenarVehiculosAscPlaca.UseVisualStyleBackColor = true;
            this.btnOrdenarVehiculosAscPlaca.Click += new System.EventHandler(this.btnOrdenarVehiculosAscPlaca_Click);
            // 
            // btnBuscarVehiculosMayorMontoPorNombreServicio
            // 
            this.btnBuscarVehiculosMayorMontoPorNombreServicio.Location = new System.Drawing.Point(25, 164);
            this.btnBuscarVehiculosMayorMontoPorNombreServicio.Name = "btnBuscarVehiculosMayorMontoPorNombreServicio";
            this.btnBuscarVehiculosMayorMontoPorNombreServicio.Size = new System.Drawing.Size(260, 43);
            this.btnBuscarVehiculosMayorMontoPorNombreServicio.TabIndex = 29;
            this.btnBuscarVehiculosMayorMontoPorNombreServicio.Text = "Buscar Vehículos con mayor monto recaudado por servicio";
            this.btnBuscarVehiculosMayorMontoPorNombreServicio.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculosMayorMontoPorNombreServicio.Click += new System.EventHandler(this.btnBuscarVehiculosMayorMontoPorNombreServicio_Click);
            // 
            // btnBuscarVehiculosMenosOrdenes
            // 
            this.btnBuscarVehiculosMenosOrdenes.Location = new System.Drawing.Point(25, 213);
            this.btnBuscarVehiculosMenosOrdenes.Name = "btnBuscarVehiculosMenosOrdenes";
            this.btnBuscarVehiculosMenosOrdenes.Size = new System.Drawing.Size(260, 43);
            this.btnBuscarVehiculosMenosOrdenes.TabIndex = 30;
            this.btnBuscarVehiculosMenosOrdenes.Text = "Buscar Vehículos con menor número de mantenimientos (órdenes)";
            this.btnBuscarVehiculosMenosOrdenes.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculosMenosOrdenes.Click += new System.EventHandler(this.btnBuscarVehiculosMenosOrdenes_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 322);
            this.Controls.Add(this.btnBuscarVehiculosMenosOrdenes);
            this.Controls.Add(this.btnBuscarVehiculosMayorMontoPorNombreServicio);
            this.Controls.Add(this.btnOrdenarVehiculosAscPlaca);
            this.Controls.Add(this.btnBuscarVehiculosMasOrdenesEnUltimos2Años);
            this.Controls.Add(this.listViewVehiculos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNombreServicio);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNombreServicio;
        private System.Windows.Forms.ListView listViewVehiculos;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnBuscarVehiculosMasOrdenesEnUltimos2Años;
        private System.Windows.Forms.Button btnOrdenarVehiculosAscPlaca;
        private System.Windows.Forms.Button btnBuscarVehiculosMayorMontoPorNombreServicio;
        private System.Windows.Forms.Button btnBuscarVehiculosMenosOrdenes;
    }
}