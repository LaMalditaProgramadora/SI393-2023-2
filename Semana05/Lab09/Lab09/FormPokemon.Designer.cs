namespace Lab09
{
    partial class FormPokemon
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listViewPokemon = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbCodigo = new TextBox();
            tbNombre = new TextBox();
            tbApodo = new TextBox();
            cbTipo = new ComboBox();
            lblTotalPsPokemon = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            tbPs = new TextBox();
            label6 = new Label();
            chBEsLegendario = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            lblTotalPokemon = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Location = new Point(599, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 66);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(17, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 348);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
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
            columnHeader4.Text = "Tipo";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "PS";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Legendario";
            columnHeader6.Width = 100;
            // 
            // listViewPokemon
            // 
            listViewPokemon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewPokemon.FullRowSelect = true;
            listViewPokemon.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewPokemon.Location = new Point(312, 12);
            listViewPokemon.Name = "listViewPokemon";
            listViewPokemon.Size = new Size(522, 237);
            listViewPokemon.TabIndex = 14;
            listViewPokemon.UseCompatibleStateImageBehavior = false;
            listViewPokemon.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 19);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 15;
            label1.Text = "Registrar Pokémon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 16;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 98);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 17;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 127);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 18;
            label4.Text = "Apodo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 156);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 19;
            label5.Text = "Tipo:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(90, 61);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(192, 23);
            tbCodigo.TabIndex = 20;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(90, 90);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(192, 23);
            tbNombre.TabIndex = 21;
            // 
            // tbApodo
            // 
            tbApodo.Location = new Point(90, 119);
            tbApodo.Name = "tbApodo";
            tbApodo.Size = new Size(192, 23);
            tbApodo.TabIndex = 22;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Acero", "Agua", "Bicho", "Dragón", "Eléctrico", "Fantasma", "Fuego", "Hada", "Hielo", "Lucha", "Normal", "Planta", "Psíquico", "Roca", "Siniestro", "Tierra", "Veneno", "Volador" });
            cbTipo.Location = new Point(90, 148);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(192, 23);
            cbTipo.TabIndex = 23;
            // 
            // lblTotalPsPokemon
            // 
            lblTotalPsPokemon.AutoSize = true;
            lblTotalPsPokemon.Location = new Point(778, 306);
            lblTotalPsPokemon.Name = "lblTotalPsPokemon";
            lblTotalPsPokemon.Size = new Size(13, 15);
            lblTotalPsPokemon.TabIndex = 35;
            lblTotalPsPokemon.Text = "0";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(90, 255);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(136, 38);
            btnRegistrar.TabIndex = 25;
            btnRegistrar.Text = "Registrar Pokémon";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(90, 299);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 38);
            btnSalir.TabIndex = 27;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tbPs
            // 
            tbPs.Location = new Point(91, 177);
            tbPs.Name = "tbPs";
            tbPs.Size = new Size(192, 23);
            tbPs.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(61, 185);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 29;
            label6.Text = "PS:";
            // 
            // chBEsLegendario
            // 
            chBEsLegendario.AutoSize = true;
            chBEsLegendario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chBEsLegendario.Location = new Point(91, 216);
            chBEsLegendario.Name = "chBEsLegendario";
            chBEsLegendario.Size = new Size(99, 19);
            chBEsLegendario.TabIndex = 30;
            chBEsLegendario.Text = "Es legendario";
            chBEsLegendario.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(657, 280);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 31;
            label7.Text = "Total de pokémons:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(623, 306);
            label8.Name = "label8";
            label8.Size = new Size(149, 15);
            label8.TabIndex = 32;
            label8.Text = "Total de PS de pokémons:";
            // 
            // lblTotalPokemon
            // 
            lblTotalPokemon.AutoSize = true;
            lblTotalPokemon.Location = new Point(778, 280);
            lblTotalPokemon.Name = "lblTotalPokemon";
            lblTotalPokemon.Size = new Size(13, 15);
            lblTotalPokemon.TabIndex = 33;
            lblTotalPokemon.Text = "0";
            // 
            // FormPokemon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 368);
            Controls.Add(lblTotalPsPokemon);
            Controls.Add(lblTotalPokemon);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(chBEsLegendario);
            Controls.Add(label6);
            Controls.Add(tbPs);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(cbTipo);
            Controls.Add(tbApodo);
            Controls.Add(tbNombre);
            Controls.Add(tbCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewPokemon);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "FormPokemon";
            Text = "Pokémon";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listViewPokemon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbCodigo;
        private TextBox tbNombre;
        private TextBox tbApodo;
        private ComboBox cbTipo;
        private Label lblTotalPsPokemon;
        private Button btnRegistrar;
        private Button btnSalir;
        private TextBox tbPs;
        private Label label6;
        private CheckBox chBEsLegendario;
        private Label label7;
        private Label label8;
        private Label lblTotalPokemon;
        private Button btnReportes;
        private ComboBox dbRegion;
        private ListView listViewEntrenador;
        private TextBox textBox1;
    }
}