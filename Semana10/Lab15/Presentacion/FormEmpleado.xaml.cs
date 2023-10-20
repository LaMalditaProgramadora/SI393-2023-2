using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para FormEmpleado.xaml
    /// </summary>
    public partial class FormEmpleado : Window
    {
        private EEmpleado empleadoSeleccionado = null;
        private NEmpleado nEmpleado = new NEmpleado();

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

            // Mostrar en el DataGrid
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

            // Mostrar en el DataGrid
            Mostrar(nEmpleado.ListarTodo());
        }

        private void btnOrdenarPorSueldo_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar en el DataGrid
            Mostrar(nEmpleado.ListarOrdenadoPorSueldo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            empleadoSeleccionado = dgEmpleados.SelectedItem as EEmpleado;
        }
    }
}
