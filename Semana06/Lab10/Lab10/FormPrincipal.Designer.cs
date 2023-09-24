namespace Lab10
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
            btnVerBuses = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnVerBuses
            // 
            btnVerBuses.Location = new Point(127, 56);
            btnVerBuses.Name = "btnVerBuses";
            btnVerBuses.Size = new Size(75, 23);
            btnVerBuses.TabIndex = 0;
            btnVerBuses.Text = "Ver Buses";
            btnVerBuses.UseVisualStyleBackColor = true;
            btnVerBuses.Click += btnVerBuses_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(127, 97);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
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
            Controls.Add(btnVerBuses);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerBuses;
        private Button btnSalir;
    }
}