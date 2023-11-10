using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerDocentes_Click(object sender, RoutedEventArgs e)
        {
            DocenteWindow window = new DocenteWindow();
            window.Show();
        }

        private void btnVerCursos_Click(object sender, RoutedEventArgs e)
        {
            CursoWindow window = new CursoWindow();
            window.Show();
        }

        private void btnAsignar_Click(object sender, RoutedEventArgs e)
        {
            DocenteXCursoWindow window = new DocenteXCursoWindow();
            window.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}