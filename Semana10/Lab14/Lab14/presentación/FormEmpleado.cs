using Lab14.entidades;
using Lab14.negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14.presentación
{
    public partial class FormEmpleado : Form
    {
        private EmpleadoNegocio eNegocio = new EmpleadoNegocio();
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void Mostrar(List<Empleado> empleados)
        {
            listViewEmpleados.Items.Clear();
            foreach (Empleado empleado in empleados)
            {
                ListViewItem fila = new ListViewItem(empleado.Dni);
                fila.SubItems.Add(empleado.Nombre);
                fila.SubItems.Add(empleado.Puesto);
                fila.SubItems.Add(empleado.Sueldo.ToString());
                listViewEmpleados.Items.Add(fila);
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

            // Creación del objeto
            Empleado empleado = new Empleado
            {
                Dni = tbDni.Text,
                Nombre = tbNombre.Text,
                Puesto = cbPuesto.Text
            };

            // Registrar el objeto
            bool registrado = eNegocio.Registrar(empleado);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro DNI");
                return;
            }

            // Mostrar en el ListView
            Mostrar(eNegocio.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación de selección
            if (listViewEmpleados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            // Eliminar
            eNegocio.Eliminar(listViewEmpleados.SelectedItems[0].Text);

            // Mostrar en el ListView
            Mostrar(eNegocio.ListarTodo());
        }

        private void btnOrdenarPorSueldo_Click(object sender, EventArgs e)
        {
            // Mostrar en el ListView
            Mostrar(eNegocio.ListarOrdenadoPorSueldo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
