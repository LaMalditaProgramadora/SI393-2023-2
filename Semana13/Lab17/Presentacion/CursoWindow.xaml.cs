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
    /// Lógica de interacción para CursoWindow.xaml
    /// </summary>
    public partial class CursoWindow : Window
    {
        private NCurso nCurso = new NCurso();
        Curso cursoSeleccionado = null;

        public CursoWindow()
        {
            InitializeComponent();
            MostrarCursos(nCurso.ListarTodo());
        }

        private void MostrarCursos(List<Curso> cursos)
        {
            dgCursos.ItemsSource = new List<Curso>();
            dgCursos.ItemsSource = cursos;
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
            Curso curso = new Curso
            {
                Nombrecurso = tbNombre.Text
            };

            // Registrar el objeto
            String mensaje = nCurso.Registrar(curso);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarCursos(nCurso.ListarTodo());
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
            if (cursoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }

            // Creación del objeto
            Curso curso = new Curso
            {
                Id_curso = cursoSeleccionado.Id_curso,
                Nombrecurso = tbNombre.Text
            };

            // Registrar el objeto
            String mensaje = nCurso.Modificar(curso);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarCursos(nCurso.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            // Validación de selección
            if (cursoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }

            // Eliminar
            String mensaje = nCurso.Eliminar(cursoSeleccionado.Id_curso);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarCursos(nCurso.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgCursos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cursoSeleccionado = dgCursos.SelectedItem as Curso;
        }
    }
}
