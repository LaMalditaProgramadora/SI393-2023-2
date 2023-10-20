using Entidades;
using Negocio;
using System.Collections.Generic;
using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para FrmPrincipal.xaml
    /// </summary>
    public partial class FormEmpleado : Window
    {
        private NEmpleado nEmpleado = new NEmpleado();
        EEmpleado empleadoSeleccionado = null;
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void Mostrar(List<EEmpleado> empleados)
        {
            dgEmpleados.ItemsSource = new List<EEmpleado>();
            dgEmpleados.ItemsSource = empleados;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbDni.Text == "" || tbNombre.Text == "" || cbPuesto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            EEmpleado empleado = new EEmpleado
            {
                Dni = tbDni.Text,
                Nombre = tbNombre.Text,
                Puesto = cbPuesto.Text
            };

            // Registrar el objeto
            bool registrado = nEmpleado.Registrar(empleado);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro DNI");
                return;
            }

            // Mostrar en el ListView
            Mostrar(nEmpleado.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            // Eliminar
            nEmpleado.Eliminar(empleadoSeleccionado.Dni);

            // Mostrar en el ListView
            Mostrar(nEmpleado.ListarTodo());
        }

        private void btnOrdenarPorSueldo_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar en el ListView
            Mostrar(nEmpleado.ListarOrdenadoPorSueldo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            empleadoSeleccionado = dgEmpleados.SelectedItem as EEmpleado;
        }
    }
}
