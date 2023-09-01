namespace Lab06
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
            tbAlbumCodigo = new TextBox();
            tbAlbumNombre = new TextBox();
            panel1 = new Panel();
            btnRegistrarAlbum = new Button();
            btnLimpiarAlbum = new Button();
            tbHeroeCaracteristicas = new TextBox();
            tbHeroeCodigo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            bRegistrarHeroe = new Button();
            tbHeroePoder = new TextBox();
            label7 = new Label();
            btnLimpiarHeroes = new Button();
            tbHeroeNombre = new TextBox();
            label8 = new Label();
            listViewAlbum = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewHeroe = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            lblAlbumMasHeroes = new Label();
            panel4 = new Panel();
            lblHeroeMenorPoder = new Label();
            lblHeroeMayorPoder = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "ÁLBUM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 105);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // tbAlbumCodigo
            // 
            tbAlbumCodigo.Location = new Point(89, 62);
            tbAlbumCodigo.Name = "tbAlbumCodigo";
            tbAlbumCodigo.Size = new Size(154, 23);
            tbAlbumCodigo.TabIndex = 3;
            // 
            // tbAlbumNombre
            // 
            tbAlbumNombre.Location = new Point(89, 97);
            tbAlbumNombre.Name = "tbAlbumNombre";
            tbAlbumNombre.Size = new Size(154, 23);
            tbAlbumNombre.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrarAlbum);
            panel1.Controls.Add(btnLimpiarAlbum);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 169);
            panel1.TabIndex = 5;
            // 
            // btnRegistrarAlbum
            // 
            btnRegistrarAlbum.Location = new Point(53, 128);
            btnRegistrarAlbum.Name = "btnRegistrarAlbum";
            btnRegistrarAlbum.Size = new Size(75, 23);
            btnRegistrarAlbum.TabIndex = 17;
            btnRegistrarAlbum.Text = "Registrar";
            btnRegistrarAlbum.UseVisualStyleBackColor = true;
            btnRegistrarAlbum.Click += btnRegistrarAlbum_Click;
            // 
            // btnLimpiarAlbum
            // 
            btnLimpiarAlbum.Location = new Point(134, 128);
            btnLimpiarAlbum.Name = "btnLimpiarAlbum";
            btnLimpiarAlbum.Size = new Size(75, 23);
            btnLimpiarAlbum.TabIndex = 15;
            btnLimpiarAlbum.Text = "Limpiar";
            btnLimpiarAlbum.UseVisualStyleBackColor = true;
            btnLimpiarAlbum.Click += btnLimpiarAlbum_Click;
            // 
            // tbHeroeCaracteristicas
            // 
            tbHeroeCaracteristicas.Location = new Point(115, 83);
            tbHeroeCaracteristicas.Name = "tbHeroeCaracteristicas";
            tbHeroeCaracteristicas.Size = new Size(154, 23);
            tbHeroeCaracteristicas.TabIndex = 10;
            // 
            // tbHeroeCodigo
            // 
            tbHeroeCodigo.Location = new Point(115, 48);
            tbHeroeCodigo.Name = "tbHeroeCodigo";
            tbHeroeCodigo.Size = new Size(154, 23);
            tbHeroeCodigo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 91);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 8;
            label4.Text = "Características:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 56);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "Código:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(245, 16);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "HÉROE";
            // 
            // panel2
            // 
            panel2.Controls.Add(bRegistrarHeroe);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(tbHeroePoder);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnLimpiarHeroes);
            panel2.Controls.Add(tbHeroeNombre);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tbHeroeCaracteristicas);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbHeroeCodigo);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(283, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 169);
            panel2.TabIndex = 11;
            // 
            // bRegistrarHeroe
            // 
            bRegistrarHeroe.Location = new Point(185, 128);
            bRegistrarHeroe.Name = "bRegistrarHeroe";
            bRegistrarHeroe.Size = new Size(75, 23);
            bRegistrarHeroe.TabIndex = 17;
            bRegistrarHeroe.Text = "Registrar";
            bRegistrarHeroe.UseVisualStyleBackColor = true;
            bRegistrarHeroe.Click += bRegistrarHeroe_Click;
            // 
            // tbHeroePoder
            // 
            tbHeroePoder.Location = new Point(351, 83);
            tbHeroePoder.Name = "tbHeroePoder";
            tbHeroePoder.Size = new Size(154, 23);
            tbHeroePoder.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 56);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 11;
            label7.Text = "Nombre:";
            // 
            // btnLimpiarHeroes
            // 
            btnLimpiarHeroes.Location = new Point(266, 128);
            btnLimpiarHeroes.Name = "btnLimpiarHeroes";
            btnLimpiarHeroes.Size = new Size(75, 23);
            btnLimpiarHeroes.TabIndex = 16;
            btnLimpiarHeroes.Text = "Limpiar";
            btnLimpiarHeroes.UseVisualStyleBackColor = true;
            btnLimpiarHeroes.Click += btnLimpiarHeroes_Click;
            // 
            // tbHeroeNombre
            // 
            tbHeroeNombre.Location = new Point(351, 48);
            tbHeroeNombre.Name = "tbHeroeNombre";
            tbHeroeNombre.Size = new Size(154, 23);
            tbHeroeNombre.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 91);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 12;
            label8.Text = "Poder:";
            // 
            // listViewAlbum
            // 
            listViewAlbum.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewAlbum.Location = new Point(12, 199);
            listViewAlbum.Name = "listViewAlbum";
            listViewAlbum.Size = new Size(256, 234);
            listViewAlbum.TabIndex = 12;
            listViewAlbum.UseCompatibleStateImageBehavior = false;
            listViewAlbum.View = View.Details;
            listViewAlbum.SelectedIndexChanged += listViewAlbum_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // listViewHeroe
            // 
            listViewHeroe.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewHeroe.Location = new Point(283, 199);
            listViewHeroe.Name = "listViewHeroe";
            listViewHeroe.Size = new Size(529, 234);
            listViewHeroe.TabIndex = 13;
            listViewHeroe.UseCompatibleStateImageBehavior = false;
            listViewHeroe.View = View.Details;
            listViewHeroe.SelectedIndexChanged += listViewHeroe_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Código";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nombre";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Características";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Poder";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 23);
            label10.Name = "label10";
            label10.Size = new Size(132, 15);
            label10.TabIndex = 14;
            label10.Text = "Álbum con más héroes:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 52);
            label11.Name = "label11";
            label11.Size = new Size(137, 15);
            label11.TabIndex = 17;
            label11.Text = "Héroe con menor poder:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 23);
            label12.Name = "label12";
            label12.Size = new Size(136, 15);
            label12.TabIndex = 18;
            label12.Text = "Héroe con mayor poder:";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblAlbumMasHeroes);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(12, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 88);
            panel3.TabIndex = 19;
            // 
            // lblAlbumMasHeroes
            // 
            lblAlbumMasHeroes.AutoSize = true;
            lblAlbumMasHeroes.Location = new Point(22, 52);
            lblAlbumMasHeroes.Name = "lblAlbumMasHeroes";
            lblAlbumMasHeroes.Size = new Size(12, 15);
            lblAlbumMasHeroes.TabIndex = 21;
            lblAlbumMasHeroes.Text = "-";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblHeroeMenorPoder);
            panel4.Controls.Add(lblHeroeMayorPoder);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(283, 447);
            panel4.Name = "panel4";
            panel4.Size = new Size(529, 88);
            panel4.TabIndex = 20;
            // 
            // lblHeroeMenorPoder
            // 
            lblHeroeMenorPoder.AutoSize = true;
            lblHeroeMenorPoder.Location = new Point(165, 52);
            lblHeroeMenorPoder.Name = "lblHeroeMenorPoder";
            lblHeroeMenorPoder.Size = new Size(12, 15);
            lblHeroeMenorPoder.TabIndex = 21;
            lblHeroeMenorPoder.Text = "-";
            // 
            // lblHeroeMayorPoder
            // 
            lblHeroeMayorPoder.AutoSize = true;
            lblHeroeMayorPoder.Location = new Point(165, 23);
            lblHeroeMayorPoder.Name = "lblHeroeMayorPoder";
            lblHeroeMayorPoder.Size = new Size(12, 15);
            lblHeroeMayorPoder.TabIndex = 19;
            lblHeroeMayorPoder.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 564);
            Controls.Add(listViewHeroe);
            Controls.Add(listViewAlbum);
            Controls.Add(tbAlbumNombre);
            Controls.Add(tbAlbumCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAlbumCodigo;
        private TextBox tbAlbumNombre;
        private Panel panel1;
        private TextBox tbHeroeCaracteristicas;
        private TextBox tbHeroeCodigo;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private TextBox tbHeroePoder;
        private Label label7;
        private TextBox tbHeroeNombre;
        private Label label8;
        private ListView listViewAlbum;
        private ListView listViewHeroe;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnRegistrarAlbum;
        private Button bRegistrarHeroe;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label10;
        private Button btnLimpiarAlbum;
        private Button btnLimpiarHeroes;
        private Label label11;
        private Label label12;
        private Panel panel3;
        private Label lblAlbumMasHeroes;
        private Panel panel4;
        private Label lblHeroeMenorPoder;
        private Label lblHeroeMayorPoder;
    }
}