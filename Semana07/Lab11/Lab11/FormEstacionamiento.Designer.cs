namespace Lab11
{
    partial class FormEstacionamiento
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
            tbMatriculaIngreso = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tbDueñoIngreso = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbMatriculaSalida = new TextBox();
            pictureBox2 = new PictureBox();
            buttonIngreso = new Button();
            buttonSalida = new Button();
            listViewEstacionamiento = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbMatriculaIngreso
            // 
            tbMatriculaIngreso.Location = new Point(102, 54);
            tbMatriculaIngreso.Name = "tbMatriculaIngreso";
            tbMatriculaIngreso.Size = new Size(154, 23);
            tbMatriculaIngreso.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(36, 57);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Matrícula:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 152);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 24);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingreso";
            // 
            // tbDueñoIngreso
            // 
            tbDueñoIngreso.Location = new Point(102, 83);
            tbDueñoIngreso.Name = "tbDueñoIngreso";
            tbDueñoIngreso.Size = new Size(154, 23);
            tbDueñoIngreso.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(51, 86);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Dueño:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(417, 24);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Salida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(325, 57);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 7;
            label6.Text = "Matrícula:";
            // 
            // tbMatriculaSalida
            // 
            tbMatriculaSalida.Location = new Point(391, 54);
            tbMatriculaSalida.Name = "tbMatriculaSalida";
            tbMatriculaSalida.Size = new Size(154, 23);
            tbMatriculaSalida.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(309, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 118);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // buttonIngreso
            // 
            buttonIngreso.Location = new Point(115, 126);
            buttonIngreso.Name = "buttonIngreso";
            buttonIngreso.Size = new Size(75, 23);
            buttonIngreso.TabIndex = 10;
            buttonIngreso.Text = "Ingresar";
            buttonIngreso.UseVisualStyleBackColor = true;
            buttonIngreso.Click += buttonIngreso_Click;
            // 
            // buttonSalida
            // 
            buttonSalida.Location = new Point(402, 97);
            buttonSalida.Name = "buttonSalida";
            buttonSalida.Size = new Size(75, 23);
            buttonSalida.TabIndex = 11;
            buttonSalida.Text = "Salir";
            buttonSalida.UseVisualStyleBackColor = true;
            buttonSalida.Click += buttonSalida_Click;
            // 
            // listViewEstacionamiento
            // 
            listViewEstacionamiento.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewEstacionamiento.Location = new Point(20, 187);
            listViewEstacionamiento.Name = "listViewEstacionamiento";
            listViewEstacionamiento.Size = new Size(549, 239);
            listViewEstacionamiento.TabIndex = 12;
            listViewEstacionamiento.UseCompatibleStateImageBehavior = false;
            listViewEstacionamiento.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Matrícula";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dueño";
            columnHeader2.Width = 250;
            // 
            // FormEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(listViewEstacionamiento);
            Controls.Add(buttonSalida);
            Controls.Add(buttonIngreso);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbMatriculaSalida);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(tbDueñoIngreso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMatriculaIngreso);
            Controls.Add(pictureBox1);
            Name = "FormEstacionamiento";
            Text = "FormEstacionamiento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMatriculaIngreso;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tbDueñoIngreso;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox tbMatriculaSalida;
        private PictureBox pictureBox2;
        private Button buttonIngreso;
        private Button buttonSalida;
        private ListView listViewEstacionamiento;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}