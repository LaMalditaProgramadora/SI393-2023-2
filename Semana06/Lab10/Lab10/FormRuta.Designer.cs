using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab10
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
            tbCodigo = new TextBox();
            tbOrigen = new TextBox();
            tbDestino = new TextBox();
            tbKilometros = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            listViewRutas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(99, 25);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(164, 23);
            tbCodigo.TabIndex = 0;
            // 
            // tbOrigen
            // 
            tbOrigen.Location = new Point(99, 54);
            tbOrigen.Name = "tbOrigen";
            tbOrigen.Size = new Size(164, 23);
            tbOrigen.TabIndex = 1;
            // 
            // tbDestino
            // 
            tbDestino.Location = new Point(99, 83);
            tbDestino.Name = "tbDestino";
            tbDestino.Size = new Size(164, 23);
            tbDestino.TabIndex = 2;
            // 
            // tbKilometros
            // 
            tbKilometros.Location = new Point(99, 112);
            tbKilometros.Name = "tbKilometros";
            tbKilometros.Size = new Size(164, 23);
            tbKilometros.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 57);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Origen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 86);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Destino:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 115);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Kilómetros:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(108, 162);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(108, 191);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listViewRutas
            // 
            listViewRutas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewRutas.Location = new Point(344, 28);
            listViewRutas.Name = "listViewRutas";
            listViewRutas.Size = new Size(419, 203);
            listViewRutas.TabIndex = 11;
            listViewRutas.UseCompatibleStateImageBehavior = false;
            listViewRutas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Origen";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Destino";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kilómetros";
            columnHeader4.Width = 100;
            // 
            // FormRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 271);
            Controls.Add(listViewRutas);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbKilometros);
            Controls.Add(tbDestino);
            Controls.Add(tbOrigen);
            Controls.Add(tbCodigo);
            Name = "FormRuta";
            Text = "formRuta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCodigo;
        private TextBox tbOrigen;
        private TextBox tbDestino;
        private TextBox tbKilometros;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvRutas;
        private Button btnRegistrar;
        private Button btnSalir;
        private ListView listViewRutas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}