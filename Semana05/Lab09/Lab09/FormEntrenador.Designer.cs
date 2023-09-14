namespace Lab09
{
    partial class FormEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrenador));
            lblTotalEntrenadores = new Label();
            label7 = new Label();
            btnSalir = new Button();
            btnVerPokemon = new Button();
            btnRegistrarEntrenador = new Button();
            cbRegion = new ComboBox();
            tbEdad = new TextBox();
            tbNombre = new TextBox();
            tbCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listViewEntrenador = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnReportes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTotalEntrenadores
            // 
            lblTotalEntrenadores.AutoSize = true;
            lblTotalEntrenadores.Location = new Point(625, 350);
            lblTotalEntrenadores.Name = "lblTotalEntrenadores";
            lblTotalEntrenadores.Size = new Size(13, 15);
            lblTotalEntrenadores.TabIndex = 55;
            lblTotalEntrenadores.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(487, 350);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 53;
            label7.Text = "Total de entrenadores:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(86, 345);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 38);
            btnSalir.TabIndex = 49;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVerPokemon
            // 
            btnVerPokemon.Location = new Point(86, 257);
            btnVerPokemon.Name = "btnVerPokemon";
            btnVerPokemon.Size = new Size(136, 38);
            btnVerPokemon.TabIndex = 48;
            btnVerPokemon.Text = "Ver Pokémon";
            btnVerPokemon.UseVisualStyleBackColor = true;
            btnVerPokemon.Click += btnVerPokemon_Click;
            // 
            // btnRegistrarEntrenador
            // 
            btnRegistrarEntrenador.Location = new Point(86, 213);
            btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            btnRegistrarEntrenador.Size = new Size(136, 38);
            btnRegistrarEntrenador.TabIndex = 47;
            btnRegistrarEntrenador.Text = "Registrar Entrenador";
            btnRegistrarEntrenador.UseVisualStyleBackColor = true;
            btnRegistrarEntrenador.Click += btnRegistrarEntrenador_Click;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Items.AddRange(new object[] { "Kanto", "Johto", "Hoenn", "Sinnoh", "Teselia/Unova", "Kalos", "Alola", "Galar", "Paldea" });
            cbRegion.Location = new Point(86, 148);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(192, 23);
            cbRegion.TabIndex = 46;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(86, 119);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(192, 23);
            tbEdad.TabIndex = 45;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(86, 90);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(192, 23);
            tbNombre.TabIndex = 44;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(86, 61);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(192, 23);
            tbCodigo.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 156);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 42;
            label5.Text = "Región:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 127);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 41;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 40;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 39;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 38;
            label1.Text = "Registrar Entrenador";
            // 
            // listViewEntrenador
            // 
            listViewEntrenador.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewEntrenador.FullRowSelect = true;
            listViewEntrenador.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewEntrenador.Location = new Point(308, 12);
            listViewEntrenador.Name = "listViewEntrenador";
            listViewEntrenador.Size = new Size(371, 317);
            listViewEntrenador.TabIndex = 37;
            listViewEntrenador.UseCompatibleStateImageBehavior = false;
            listViewEntrenador.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apodo";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Región";
            columnHeader4.Width = 100;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(13, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 392);
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Location = new Point(444, 341);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 37);
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(86, 301);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(136, 38);
            btnReportes.TabIndex = 59;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // FormEntrenador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(694, 414);
            Controls.Add(btnReportes);
            Controls.Add(lblTotalEntrenadores);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnVerPokemon);
            Controls.Add(btnRegistrarEntrenador);
            Controls.Add(cbRegion);
            Controls.Add(tbEdad);
            Controls.Add(tbNombre);
            Controls.Add(tbCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewEntrenador);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEntrenador";
            Text = "Entrenador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTotalEntrenadores;
        private Label label7;
        private Button btnSalir;
        private Button btnVerPokemon;
        private Button btnRegistrarEntrenador;
        private ComboBox cbRegion;
        private TextBox tbEdad;
        private TextBox tbNombre;
        private TextBox tbCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listViewEntrenador;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnReportes;
    }
}