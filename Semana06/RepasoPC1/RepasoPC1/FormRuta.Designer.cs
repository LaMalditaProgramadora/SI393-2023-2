namespace RepasoPC1
{
    partial class FormRuta
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
            btnSalir = new Button();
            btnRutaRegistrar = new Button();
            label4 = new Label();
            cbRutaOrigen = new ComboBox();
            dgvRutas = new DataGridView();
            label3 = new Label();
            tbRutaKilometros = new TextBox();
            tbRutaCodigo = new TextBox();
            label2 = new Label();
            cbRutaDestino = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(116, 193);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRutaRegistrar
            // 
            btnRutaRegistrar.Location = new Point(116, 164);
            btnRutaRegistrar.Name = "btnRutaRegistrar";
            btnRutaRegistrar.Size = new Size(75, 23);
            btnRutaRegistrar.TabIndex = 21;
            btnRutaRegistrar.Text = "Registrar";
            btnRutaRegistrar.UseVisualStyleBackColor = true;
            btnRutaRegistrar.Click += btnRutaRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 56);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 20;
            label4.Text = "Origen:";
            // 
            // cbRutaOrigen
            // 
            cbRutaOrigen.FormattingEnabled = true;
            cbRutaOrigen.Items.AddRange(new object[] { "Origen 1", "Origen 2", "Origen 3" });
            cbRutaOrigen.Location = new Point(102, 53);
            cbRutaOrigen.Name = "cbRutaOrigen";
            cbRutaOrigen.Size = new Size(160, 23);
            cbRutaOrigen.TabIndex = 19;
            // 
            // dgvRutas
            // 
            dgvRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRutas.Location = new Point(296, 24);
            dgvRutas.Name = "dgvRutas";
            dgvRutas.RowTemplate.Height = 25;
            dgvRutas.Size = new Size(479, 221);
            dgvRutas.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 85);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 17;
            label3.Text = "Destino:";
            // 
            // tbRutaKilometros
            // 
            tbRutaKilometros.Location = new Point(102, 111);
            tbRutaKilometros.Name = "tbRutaKilometros";
            tbRutaKilometros.Size = new Size(160, 23);
            tbRutaKilometros.TabIndex = 16;
            // 
            // tbRutaCodigo
            // 
            tbRutaCodigo.Location = new Point(102, 24);
            tbRutaCodigo.Name = "tbRutaCodigo";
            tbRutaCodigo.Size = new Size(160, 23);
            tbRutaCodigo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 27);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 14;
            label2.Text = "Código:";
            // 
            // cbRutaDestino
            // 
            cbRutaDestino.FormattingEnabled = true;
            cbRutaDestino.Items.AddRange(new object[] { "Destino 1", "Destino 2", "Destino 3" });
            cbRutaDestino.Location = new Point(102, 82);
            cbRutaDestino.Name = "cbRutaDestino";
            cbRutaDestino.Size = new Size(160, 23);
            cbRutaDestino.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 114);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 26;
            label1.Text = "Kilómetros:";
            // 
            // FormRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 274);
            Controls.Add(label1);
            Controls.Add(cbRutaDestino);
            Controls.Add(btnSalir);
            Controls.Add(btnRutaRegistrar);
            Controls.Add(label4);
            Controls.Add(cbRutaOrigen);
            Controls.Add(dgvRutas);
            Controls.Add(label3);
            Controls.Add(tbRutaKilometros);
            Controls.Add(tbRutaCodigo);
            Controls.Add(label2);
            Name = "FormRuta";
            Text = "Información de Ruta";
            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReportes;
        private Button btnVerRutas;
        private Button btnSalir;
        private Button btnRutaRegistrar;
        private Label label4;
        private ComboBox cbRutaOrigen;
        private DataGridView dgvRutas;
        private DataGridViewTextBoxColumn Matrícula;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Conductor;
        private Label label3;
        private TextBox tbRutaKilometros;
        private TextBox tbRutaCodigo;
        private Label label2;
        private ComboBox cbRutaDestino;
        private Label label1;
    }
}