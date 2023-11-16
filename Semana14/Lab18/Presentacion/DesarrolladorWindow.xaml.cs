using Datos;
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
    /// Lógica de interacción para DesarrolladorWindow.xaml
    /// </summary>
    public partial class DesarrolladorWindow : Window
    {
        private NDesarrollador nDesarrollador = new NDesarrollador();
        private Desarrollador desarrolladorSeleccionado = null;

        public DesarrolladorWindow()
        {
            InitializeComponent();
            MostrarDesarrolladors(nDesarrollador.ListarTodo());
        }

        private void MostrarDesarrolladors(List<Desarrollador> desarrolladors)
        {
            dgDesarrolladores.ItemsSource = new List<Desarrollador>();
            dgDesarrolladores.ItemsSource = desarrolladors;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Desarrollador desarrollador = new Desarrollador
            {
                Nombre = tbNombre.Text
            };

            // Registrar el objeto
            String mensaje = nDesarrollador.Registrar(desarrollador);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDesarrolladors(nDesarrollador.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (desarrolladorSeleccionado == null)
            {
                MessageBox.Show("Seleccione un desarrollador");
                return;
            }

            // Creación del objeto
            Desarrollador desarrollador = new Desarrollador
            {
                Id_Desarrollador = desarrolladorSeleccionado.Id_Desarrollador,
                Nombre = tbNombre.Text
            };

            // Registrar el objeto
            String mensaje = nDesarrollador.Modificar(desarrollador);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDesarrolladors(nDesarrollador.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            // Validación de selección
            if (desarrolladorSeleccionado == null)
            {
                MessageBox.Show("Seleccione un desarrollador");
                return;
            }

            // Eliminar
            String mensaje = nDesarrollador.Eliminar(desarrolladorSeleccionado.Id_Desarrollador);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDesarrolladors(nDesarrollador.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgDesarrolladores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            desarrolladorSeleccionado = dgDesarrolladores.SelectedItem as Desarrollador;
        }
    }
}
