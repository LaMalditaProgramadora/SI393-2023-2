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
    /// Lógica de interacción para DocenteXCursoWindow.xaml
    /// </summary>
    public partial class DocenteXCursoWindow : Window
    {
        private NDocenteXCurso nDocenteXCurso = new NDocenteXCurso();
        private NCurso nCurso = new NCurso();
        private NDocente nDocente = new NDocente();

        public DocenteXCursoWindow()
        {
            InitializeComponent();
            MostrarDocentes(nDocente.ListarTodo());
            MostrarCursos(nCurso.ListarTodo());
            MostrarDocenteXCursos(nDocenteXCurso.ListarTodo());
        }

        private void MostrarDocenteXCursos(List<DocentexCurso> docenteXCursos)
        {
            dgDocenteXCursos.ItemsSource = new List<DocentexCurso>();
            dgDocenteXCursos.ItemsSource = docenteXCursos;
        }

        private void MostrarDocentes(List<Docente> docentes)
        {
            cbDocentes.ItemsSource = new List<Docente>();
            cbDocentes.ItemsSource = docentes;
            cbDocentes.DisplayMemberPath = "Nombre";
            cbDocentes.SelectedValuePath = "Id_docente";
        }

        private void MostrarCursos(List<Curso> cursos)
        {
            cbCursos.ItemsSource = new List<Curso>();
            cbCursos.ItemsSource = cursos;
            cbCursos.DisplayMemberPath = "Nombrecurso";
            cbCursos.SelectedValuePath = "Id_curso";
        }

        private void btnAsignar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (cbCursos.Text == "" || cbDocentes.Text == "" || tbSemestre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            DocentexCurso docenteXCurso = new DocentexCurso
            {
                Id_docente = (int)cbDocentes.SelectedValue,
                Id_curso = (int)cbCursos.SelectedValue,
                Semestre = tbSemestre.Text
            };

            // Asignar el objeto
            String mensaje = nDocenteXCurso.Asignar(docenteXCurso);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDocenteXCursos(nDocenteXCurso.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
