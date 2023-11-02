using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Lógica de interacción para AlumnoWindow.xaml
    /// </summary>
    public partial class AlumnoWindow : Window
    {
        private NAlumno nAlumno = new NAlumno();
        private Alumno alumnoSeleccionado = null;

        public AlumnoWindow()
        {
            InitializeComponent();
            MostrarAlumnos(nAlumno.ListarTodo());
        }

        private void MostrarAlumnos(List<Alumno> alumnos)
        {
            dgAlumnos.ItemsSource = new List<Alumno>();
            dgAlumnos.ItemsSource = alumnos;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedioTA.Text == "" || tbPC2.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Alumno alumno = new Alumno
            {
                Codigo = tbCodigo.Text,
                NombreCompleto = tbNombre.Text,
                PromedioTA = Decimal.Parse(tbPromedioTA.Text),
                PC2 = Decimal.Parse(tbPC2.Text)
            };

            // Registrar el objeto
            String mensaje = nAlumno.Registrar(alumno);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarAlumnos(nAlumno.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (alumnoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }

            // Eliminar
            String mensaje = nAlumno.Elimnar(alumnoSeleccionado.Id);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarAlumnos(nAlumno.ListarTodo());
        }

        private void btnOrdenarPorNotaFinalPC2_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar en el DataGrid
            MostrarAlumnos(nAlumno.ListarTodoOrdenadoPorNotaFinalPC2());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            alumnoSeleccionado = dgAlumnos.SelectedItem as Alumno;
        }
    }
}
