namespace Lab09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            btnBuscarPorMenorCantPokemon = new Button();
            lblTotalEntrenadores = new Label();
            label7 = new Label();
            btnSalir = new Button();
            btnBuscarPorRegion = new Button();
            btnBuscarPorNombrePokemon = new Button();
            cbRegion = new ComboBox();
            tbNombre = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            listViewEntrenador = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarPorMenorCantPokemon
            // 
            btnBuscarPorMenorCantPokemon.Location = new Point(77, 246);
            btnBuscarPorMenorCantPokemon.Name = "btnBuscarPorMenorCantPokemon";
            btnBuscarPorMenorCantPokemon.Size = new Size(149, 38);
            btnBuscarPorMenorCantPokemon.TabIndex = 77;
            btnBuscarPorMenorCantPokemon.Text = "Buscar por menor cantidad de pokémons";
            btnBuscarPorMenorCantPokemon.UseVisualStyleBackColor = true;
            btnBuscarPorMenorCantPokemon.Click += btnBuscarPorMenorCantPokemon_Click;
            // 
            // lblTotalEntrenadores
            // 
            lblTotalEntrenadores.AutoSize = true;
            lblTotalEntrenadores.Location = new Point(619, 348);
            lblTotalEntrenadores.Name = "lblTotalEntrenadores";
            lblTotalEntrenadores.Size = new Size(13, 15);
            lblTotalEntrenadores.TabIndex = 74;
            lblTotalEntrenadores.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(481, 350);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 73;
            label7.Text = "Total de entrenadores:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(78, 290);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(148, 38);
            btnSalir.TabIndex = 72;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBuscarPorRegion
            // 
            btnBuscarPorRegion.Location = new Point(93, 177);
            btnBuscarPorRegion.Name = "btnBuscarPorRegion";
            btnBuscarPorRegion.Size = new Size(123, 38);
            btnBuscarPorRegion.TabIndex = 71;
            btnBuscarPorRegion.Text = "Buscar por región";
            btnBuscarPorRegion.UseVisualStyleBackColor = true;
            btnBuscarPorRegion.Click += btnBuscarPorRegion_Click;
            // 
            // btnBuscarPorNombrePokemon
            // 
            btnBuscarPorNombrePokemon.Location = new Point(93, 90);
            btnBuscarPorNombrePokemon.Name = "btnBuscarPorNombrePokemon";
            btnBuscarPorNombrePokemon.Size = new Size(123, 38);
            btnBuscarPorNombrePokemon.TabIndex = 70;
            btnBuscarPorNombrePokemon.Text = "Buscar por nombre del pokémon";
            btnBuscarPorNombrePokemon.UseVisualStyleBackColor = true;
            btnBuscarPorNombrePokemon.Click += btnBuscarPorNombrePokemon_Click;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Items.AddRange(new object[] { "Kanto", "Johto", "Hoenn", "Sinnoh", "Teselia/Unova", "Kalos", "Alola", "Galar", "Paldea" });
            cbRegion.Location = new Point(80, 148);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(192, 23);
            cbRegion.TabIndex = 69;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(80, 61);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(192, 23);
            tbNombre.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 156);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 65;
            label5.Text = "Región:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 69);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 63;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 61;
            label1.Text = "Reportes Entrenador";
            // 
            // listViewEntrenador
            // 
            listViewEntrenador.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewEntrenador.FullRowSelect = true;
            listViewEntrenador.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewEntrenador.Location = new Point(302, 12);
            listViewEntrenador.Name = "listViewEntrenador";
            listViewEntrenador.Size = new Size(371, 317);
            listViewEntrenador.TabIndex = 60;
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
            pictureBox1.Location = new Point(7, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 343);
            pictureBox1.TabIndex = 75;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Location = new Point(438, 341);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 37);
            pictureBox2.TabIndex = 76;
            pictureBox2.TabStop = false;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(696, 396);
            Controls.Add(btnBuscarPorMenorCantPokemon);
            Controls.Add(lblTotalEntrenadores);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscarPorRegion);
            Controls.Add(btnBuscarPorNombrePokemon);
            Controls.Add(cbRegion);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listViewEntrenador);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReporte";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarPorMenorCantPokemon;
        private Label lblTotalEntrenadores;
        private Label label7;
        private Button btnSalir;
        private Button btnBuscarPorRegion;
        private Button btnBuscarPorNombrePokemon;
        private ComboBox cbRegion;
        private TextBox tbNombre;
        private Label label5;
        private Label label3;
        private Label label1;
        private ListView listViewEntrenador;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}