namespace Lab08
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbAgenciaCodigo = new TextBox();
            tbAgenciaDireccion = new TextBox();
            tbAgenciaCiudad = new TextBox();
            tbAgenciaTelefono = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbInmueblePrecio = new TextBox();
            tbInmuebleSuperficie = new TextBox();
            tbInmuebleDireccion = new TextBox();
            tbInmuebleCodigo = new TextBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            listViewAgencias = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewInmuebles = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tbBuscar = new TextBox();
            label13 = new Label();
            btnBuscar = new Button();
            btnAgregarAgencia = new Button();
            btnAgregarInmueble = new Button();
            btnAgenciasAlquilerInmueblesMayorSuperficie = new Button();
            btnAgenciasMayorCantidadInmueblesVenta = new Button();
            label12 = new Label();
            lblMontoTotalAlquilerInmuebles = new Label();
            cbInmuebleCondicion = new ComboBox();
            btnLimpiarAgencia = new Button();
            btnLimpiarInmueble = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 233);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "AGENCIA";
            // 
            // tbAgenciaCodigo
            // 
            tbAgenciaCodigo.Location = new Point(107, 55);
            tbAgenciaCodigo.Name = "tbAgenciaCodigo";
            tbAgenciaCodigo.Size = new Size(186, 23);
            tbAgenciaCodigo.TabIndex = 2;
            // 
            // tbAgenciaDireccion
            // 
            tbAgenciaDireccion.Location = new Point(107, 84);
            tbAgenciaDireccion.Name = "tbAgenciaDireccion";
            tbAgenciaDireccion.Size = new Size(186, 23);
            tbAgenciaDireccion.TabIndex = 3;
            // 
            // tbAgenciaCiudad
            // 
            tbAgenciaCiudad.Location = new Point(107, 113);
            tbAgenciaCiudad.Name = "tbAgenciaCiudad";
            tbAgenciaCiudad.Size = new Size(186, 23);
            tbAgenciaCiudad.TabIndex = 4;
            // 
            // tbAgenciaTelefono
            // 
            tbAgenciaTelefono.Location = new Point(107, 142);
            tbAgenciaTelefono.Name = "tbAgenciaTelefono";
            tbAgenciaTelefono.Size = new Size(186, 23);
            tbAgenciaTelefono.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 58);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 116);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Ciudad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 145);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 145);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 19;
            label6.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(388, 116);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 18;
            label7.Text = "Superficie:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 87);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 17;
            label8.Text = "Dirección:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 58);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 16;
            label9.Text = "Código:";
            // 
            // tbInmueblePrecio
            // 
            tbInmueblePrecio.Location = new Point(456, 142);
            tbInmueblePrecio.Name = "tbInmueblePrecio";
            tbInmueblePrecio.Size = new Size(243, 23);
            tbInmueblePrecio.TabIndex = 15;
            // 
            // tbInmuebleSuperficie
            // 
            tbInmuebleSuperficie.Location = new Point(456, 113);
            tbInmuebleSuperficie.Name = "tbInmuebleSuperficie";
            tbInmuebleSuperficie.Size = new Size(243, 23);
            tbInmuebleSuperficie.TabIndex = 14;
            // 
            // tbInmuebleDireccion
            // 
            tbInmuebleDireccion.Location = new Point(456, 84);
            tbInmuebleDireccion.Name = "tbInmuebleDireccion";
            tbInmuebleDireccion.Size = new Size(243, 23);
            tbInmuebleDireccion.TabIndex = 13;
            // 
            // tbInmuebleCodigo
            // 
            tbInmuebleCodigo.Location = new Point(456, 55);
            tbInmuebleCodigo.Name = "tbInmuebleCodigo";
            tbInmuebleCodigo.Size = new Size(243, 23);
            tbInmuebleCodigo.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(515, 26);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 11;
            label10.Text = "INMUEBLE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(333, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(421, 262);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(385, 174);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 21;
            label11.Text = "Condicion:";
            // 
            // listViewAgencias
            // 
            listViewAgencias.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewAgencias.Location = new Point(21, 271);
            listViewAgencias.Name = "listViewAgencias";
            listViewAgencias.Size = new Size(293, 201);
            listViewAgencias.TabIndex = 22;
            listViewAgencias.UseCompatibleStateImageBehavior = false;
            listViewAgencias.View = View.Details;
            listViewAgencias.SelectedIndexChanged += listViewAgencias_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dirección";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ciudad";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 70;
            // 
            // listViewInmuebles
            // 
            listViewInmuebles.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listViewInmuebles.Location = new Point(333, 300);
            listViewInmuebles.Name = "listViewInmuebles";
            listViewInmuebles.Size = new Size(421, 224);
            listViewInmuebles.TabIndex = 23;
            listViewInmuebles.UseCompatibleStateImageBehavior = false;
            listViewInmuebles.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Código";
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Dirección";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Superfie";
            columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Precio";
            columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Condición";
            columnHeader9.Width = 90;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Location = new Point(21, 498);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 123);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox4.Location = new Point(333, 546);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(421, 75);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(468, 560);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(174, 23);
            tbBuscar.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(352, 563);
            label13.Name = "label13";
            label13.Size = new Size(110, 15);
            label13.TabIndex = 29;
            label13.Text = "Buscar por agencia:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(648, 559);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 23);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar Venta";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregarAgencia
            // 
            btnAgregarAgencia.Location = new Point(41, 177);
            btnAgregarAgencia.Name = "btnAgregarAgencia";
            btnAgregarAgencia.Size = new Size(252, 23);
            btnAgregarAgencia.TabIndex = 31;
            btnAgregarAgencia.Text = "Agregar";
            btnAgregarAgencia.UseVisualStyleBackColor = true;
            btnAgregarAgencia.Click += btnAgregarAgencia_Click;
            // 
            // btnAgregarInmueble
            // 
            btnAgregarInmueble.Location = new Point(385, 205);
            btnAgregarInmueble.Name = "btnAgregarInmueble";
            btnAgregarInmueble.Size = new Size(314, 23);
            btnAgregarInmueble.TabIndex = 32;
            btnAgregarInmueble.Text = "Agregar";
            btnAgregarInmueble.UseVisualStyleBackColor = true;
            btnAgregarInmueble.Click += btnAgregarInmueble_Click;
            // 
            // btnAgenciasAlquilerInmueblesMayorSuperficie
            // 
            btnAgenciasAlquilerInmueblesMayorSuperficie.Location = new Point(41, 511);
            btnAgenciasAlquilerInmueblesMayorSuperficie.Name = "btnAgenciasAlquilerInmueblesMayorSuperficie";
            btnAgenciasAlquilerInmueblesMayorSuperficie.Size = new Size(252, 43);
            btnAgenciasAlquilerInmueblesMayorSuperficie.TabIndex = 33;
            btnAgenciasAlquilerInmueblesMayorSuperficie.Text = "Buscar las que alquilan inmuebles con mayor superficie";
            btnAgenciasAlquilerInmueblesMayorSuperficie.UseVisualStyleBackColor = true;
            btnAgenciasAlquilerInmueblesMayorSuperficie.Click += btnAgenciasAlquilerInmueblesMayorSuperficie_Click;
            // 
            // btnAgenciasMayorCantidadInmueblesVenta
            // 
            btnAgenciasMayorCantidadInmueblesVenta.Location = new Point(41, 560);
            btnAgenciasMayorCantidadInmueblesVenta.Name = "btnAgenciasMayorCantidadInmueblesVenta";
            btnAgenciasMayorCantidadInmueblesVenta.Size = new Size(252, 43);
            btnAgenciasMayorCantidadInmueblesVenta.TabIndex = 34;
            btnAgenciasMayorCantidadInmueblesVenta.Text = "Buscar las tienen más inmuebles en venta";
            btnAgenciasMayorCantidadInmueblesVenta.UseVisualStyleBackColor = true;
            btnAgenciasMayorCantidadInmueblesVenta.Click += btnAgenciasMayorCantidadInmueblesVenta_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(347, 587);
            label12.Name = "label12";
            label12.Size = new Size(115, 15);
            label12.TabIndex = 35;
            label12.Text = "Monto total alquiler:";
            // 
            // lblMontoTotalAlquilerInmuebles
            // 
            lblMontoTotalAlquilerInmuebles.AutoSize = true;
            lblMontoTotalAlquilerInmuebles.Location = new Point(468, 587);
            lblMontoTotalAlquilerInmuebles.Name = "lblMontoTotalAlquilerInmuebles";
            lblMontoTotalAlquilerInmuebles.Size = new Size(13, 15);
            lblMontoTotalAlquilerInmuebles.TabIndex = 36;
            lblMontoTotalAlquilerInmuebles.Text = "0";
            // 
            // cbInmuebleCondicion
            // 
            cbInmuebleCondicion.FormattingEnabled = true;
            cbInmuebleCondicion.Items.AddRange(new object[] { "Venta", "Alquiler" });
            cbInmuebleCondicion.Location = new Point(456, 171);
            cbInmuebleCondicion.Name = "cbInmuebleCondicion";
            cbInmuebleCondicion.Size = new Size(243, 23);
            cbInmuebleCondicion.TabIndex = 37;
            // 
            // btnLimpiarAgencia
            // 
            btnLimpiarAgencia.Location = new Point(41, 206);
            btnLimpiarAgencia.Name = "btnLimpiarAgencia";
            btnLimpiarAgencia.Size = new Size(252, 23);
            btnLimpiarAgencia.TabIndex = 38;
            btnLimpiarAgencia.Text = "Limpiar";
            btnLimpiarAgencia.UseVisualStyleBackColor = true;
            btnLimpiarAgencia.Click += btnLimpiarAgencia_Click;
            // 
            // btnLimpiarInmueble
            // 
            btnLimpiarInmueble.Location = new Point(385, 234);
            btnLimpiarInmueble.Name = "btnLimpiarInmueble";
            btnLimpiarInmueble.Size = new Size(314, 23);
            btnLimpiarInmueble.TabIndex = 39;
            btnLimpiarInmueble.Text = "Limpiar";
            btnLimpiarInmueble.UseVisualStyleBackColor = true;
            btnLimpiarInmueble.Click += btnLimpiarInmueble_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 643);
            Controls.Add(btnLimpiarInmueble);
            Controls.Add(btnLimpiarAgencia);
            Controls.Add(cbInmuebleCondicion);
            Controls.Add(lblMontoTotalAlquilerInmuebles);
            Controls.Add(label12);
            Controls.Add(btnAgenciasMayorCantidadInmueblesVenta);
            Controls.Add(btnAgenciasAlquilerInmueblesMayorSuperficie);
            Controls.Add(btnAgregarInmueble);
            Controls.Add(btnAgregarAgencia);
            Controls.Add(btnBuscar);
            Controls.Add(label13);
            Controls.Add(tbBuscar);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(listViewInmuebles);
            Controls.Add(listViewAgencias);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(tbInmueblePrecio);
            Controls.Add(tbInmuebleSuperficie);
            Controls.Add(tbInmuebleDireccion);
            Controls.Add(tbInmuebleCodigo);
            Controls.Add(label10);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbAgenciaTelefono);
            Controls.Add(tbAgenciaCiudad);
            Controls.Add(tbAgenciaDireccion);
            Controls.Add(tbAgenciaCodigo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbAgenciaCodigo;
        private TextBox tbAgenciaDireccion;
        private TextBox tbAgenciaCiudad;
        private TextBox tbAgenciaTelefono;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbInmueblePrecio;
        private TextBox tbInmuebleSuperficie;
        private TextBox tbInmuebleDireccion;
        private TextBox tbInmuebleCodigo;
        private Label label10;
        private PictureBox pictureBox2;
        private Label label11;
        private ListView listViewAgencias;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewInmuebles;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox tbBuscar;
        private Label label13;
        private Button btnBuscar;
        private Button btnAgregarAgencia;
        private Button btnAgregarInmueble;
        private Button btnAgenciasAlquilerInmueblesMayorSuperficie;
        private Button btnAgenciasMayorCantidadInmueblesVenta;
        private Label label12;
        private Label lblMontoTotalAlquilerInmuebles;
        private ComboBox cbInmuebleCondicion;
        private Button btnLimpiarAgencia;
        private Button btnLimpiarInmueble;
    }
}