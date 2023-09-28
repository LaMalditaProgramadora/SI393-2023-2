namespace Lab12
{
    partial class FormPrincipal
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
            btnVerDoctores = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnVerDoctores
            // 
            btnVerDoctores.Location = new Point(108, 54);
            btnVerDoctores.Name = "btnVerDoctores";
            btnVerDoctores.Size = new Size(98, 23);
            btnVerDoctores.TabIndex = 0;
            btnVerDoctores.Text = "Ver Doctores";
            btnVerDoctores.UseVisualStyleBackColor = true;
            btnVerDoctores.Click += btnVerDoctores_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(108, 97);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 180);
            Controls.Add(btnSalir);
            Controls.Add(btnVerDoctores);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerDoctores;
        private Button btnSalir;
    }
}