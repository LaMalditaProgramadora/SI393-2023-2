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

        private void btnVerDesarrolladores_Click(object sender, RoutedEventArgs e)
        {
            DesarrolladorWindow window = new DesarrolladorWindow();
            window.Show();
        }

        private void btnVerVideojuegos_Click(object sender, RoutedEventArgs e)
        {
            VideojuegoWindow window = new VideojuegoWindow();
            window.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
