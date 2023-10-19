namespace Lab14.presentación
{
    partial class FormEmpleado
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
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewEmpleados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnOrdenarPorSueldo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(69, 12);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(149, 20);
            this.tbDni.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(69, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(149, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Auxiliar",
            "Asistente",
            "Administrador"});
            this.cbPuesto.Location = new System.Drawing.Point(69, 64);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(149, 21);
            this.cbPuesto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puesto:";
            // 
            // listViewEmpleados
            // 
            this.listViewEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEmpleados.HideSelection = false;
            this.listViewEmpleados.Location = new System.Drawing.Point(241, 12);
            this.listViewEmpleados.Name = "listViewEmpleados";
            this.listViewEmpleados.Size = new System.Drawing.Size(512, 206);
            this.listViewEmpleados.TabIndex = 6;
            this.listViewEmpleados.UseCompatibleStateImageBehavior = false;
            this.listViewEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Puesto";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sueldo";
            this.columnHeader4.Width = 100;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(63, 108);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(126, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(63, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnOrdenarPorSueldo
            // 
            this.btnOrdenarPorSueldo.Location = new System.Drawing.Point(63, 166);
            this.btnOrdenarPorSueldo.Name = "btnOrdenarPorSueldo";
            this.btnOrdenarPorSueldo.Size = new System.Drawing.Size(126, 23);
            this.btnOrdenarPorSueldo.TabIndex = 9;
            this.btnOrdenarPorSueldo.Text = "Ordenar por Sueldo";
            this.btnOrdenarPorSueldo.UseVisualStyleBackColor = true;
            this.btnOrdenarPorSueldo.Click += new System.EventHandler(this.btnOrdenarPorSueldo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(63, 195);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 234);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenarPorSueldo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.listViewEmpleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDni);
            this.Name = "FormEmpleado";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewEmpleados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnOrdenarPorSueldo;
        private System.Windows.Forms.Button btnSalir;
    }
}