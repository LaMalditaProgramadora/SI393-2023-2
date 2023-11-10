using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para DocenteXCursoWindow.xaml
    /// </summary>
    public partial class DocenteXCursoWindow : Window
    {
        private NDocenteXCurso nDocenteXCurso = new NDocenteXCurso();
        private NDocente nDocente = new NDocente();
        private NCurso nCurso = new NCurso();

        public DocenteXCursoWindow()
        {
            InitializeComponent();
            MostrarCursos(nCurso.ListarTodo());
            MostrarDocentes(nDocente.ListarTodo());
            MostrarDocenteXCursos(nDocenteXCurso.ListarTodo());
        }

        private void MostrarDocentes(List<Docente> docentes)
        {
            cbDocente.ItemsSource = new List<Docente>();
            cbDocente.ItemsSource = docentes;
            cbDocente.DisplayMemberPath = "Nombre";
            cbDocente.SelectedValuePath = "Id_docente";
        }

        private void MostrarCursos(List<Curso> cursos)
        {
            cbCurso.ItemsSource = new List<Curso>();
            cbCurso.ItemsSource = cursos;
            cbCurso.DisplayMemberPath = "Nombrecurso";
            cbCurso.SelectedValuePath = "Id_curso";
        }

        private void MostrarDocenteXCursos(List<DocentexCurso> docenteXCursos)
        {
            dgLista.ItemsSource = new List<DocentexCurso>();
            dgLista.ItemsSource = docenteXCursos;
        }

        private void btnAsignar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (cbCurso.Text == "" || cbDocente.Text == "" || tbSemestre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            DocentexCurso docenteXCurso = new DocentexCurso
            {
                Id_docente = (int)cbDocente.SelectedValue,
                Id_curso = (int)cbCurso.SelectedValue,
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
