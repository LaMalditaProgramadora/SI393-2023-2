using Lab14.entidades;
using Lab14.negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab14.presentación
{
    public partial class FormTrabajador : Form
    {
        private TrabajadorNegocio tNegocio = new TrabajadorNegocio();
        public FormTrabajador()
        {
            InitializeComponent();
        }

        private void Mostrar(List<Trabajador> trabajadores)
        {
            listViewTrabajadores.Items.Clear();
            foreach (Trabajador trabajador in trabajadores)
            {
                ListViewItem fila = new ListViewItem(trabajador.Dni);
                fila.SubItems.Add(trabajador.Nombre);
                fila.SubItems.Add(trabajador.Puesto);
                fila.SubItems.Add(trabajador.Sueldo.ToString());
                listViewTrabajadores.Items.Add(fila);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbDni.Text == "" || tbNombre.Text == "" || cbPuesto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación de objeto
            Trabajador trabajador = new Trabajador {
                Dni = tbDni.Text,
                Nombre = tbNombre.Text,
                Puesto = cbPuesto.Text
            };

            // Registrar
            bool registrado = tNegocio.Registrar(trabajador);
            if (!registrado) {
                MessageBox.Show("Ingrese otro DNI");
                return;
            }

            // Mostrar en ListView
            Mostrar(tNegocio.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación de selección
            if (listViewTrabajadores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un trabajador");
                return;
            }

            // Eliminar
            tNegocio.Eliminar(listViewTrabajadores.SelectedItems[0].Text);

            // Mostrar en ListView
            Mostrar(tNegocio.ListarTodo());
        }

        private void btnOrdenarPorSueldo_Click(object sender, EventArgs e)
        {
            // Mostrar en ListView
            Mostrar(tNegocio.ListarOrdenadoPorSueldo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
