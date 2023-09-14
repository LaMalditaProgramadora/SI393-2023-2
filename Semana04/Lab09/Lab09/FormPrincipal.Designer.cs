namespace Lab09
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pictureBox1 = new PictureBox();
            btnRegistrarEntrenador = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pokemonLeague;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRegistrarEntrenador
            // 
            btnRegistrarEntrenador.Location = new Point(136, 204);
            btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            btnRegistrarEntrenador.Size = new Size(136, 38);
            btnRegistrarEntrenador.TabIndex = 1;
            btnRegistrarEntrenador.Text = "Registrar Entrenador";
            btnRegistrarEntrenador.UseVisualStyleBackColor = true;
            btnRegistrarEntrenador.Click += btnRegistrarEntrenador_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(136, 253);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 38);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 316);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarEntrenador);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "Liga Pokémon";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnRegistrarEntrenador;
        private Button btnSalir;
    }
}