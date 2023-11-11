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
    /// Lógica de interacción para DocenteWindow.xaml
    /// </summary>
    public partial class DocenteWindow : Window
    {
        private NDocente nDocente = new NDocente();
        Docente docenteSeleccionado = null;

        public DocenteWindow()
        {
            InitializeComponent();
            MostrarDocentes(nDocente.ListarTodo());
        }

        private void MostrarDocentes(List<Docente> docentes)
        {
            dgDocentes.ItemsSource = new List<Docente>();
            dgDocentes.ItemsSource = docentes;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbEscuela.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Docente docente = new Docente
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Escuela = tbEscuela.Text
            };

            // Registrar el objeto
            String mensaje = nDocente.Registrar(docente);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDocentes(nDocente.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbEscuela.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (docenteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un docente");
                return;
            }

            // Creación del objeto
            Docente docente = new Docente
            {
                Id_docente = docenteSeleccionado.Id_docente,
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Escuela = tbEscuela.Text
            };

            // Registrar el objeto
            String mensaje = nDocente.Modificar(docente);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDocentes(nDocente.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            // Validación de selección
            if (docenteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un docente");
                return;
            }

            // Eliminar
            String mensaje = nDocente.Eliminar(docenteSeleccionado.Id_docente);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDocentes(nDocente.ListarTodo());
        }

        private void btnBuscarPorEscuela_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbEscuela.Text == "")
            {
                MessageBox.Show("Ingrese escuela");
                return;
            }

            // Mostrar en el DataGrid
            MostrarDocentes(nDocente.ListarTodoPorEscuela(tbEscuela.Text));
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgDocentes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            docenteSeleccionado = dgDocentes.SelectedItem as Docente;
        }
    }
}
