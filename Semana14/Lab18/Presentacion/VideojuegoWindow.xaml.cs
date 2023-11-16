using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para VideojuegoWindow.xaml
    /// </summary>
    public partial class VideojuegoWindow : Window
    {
        private NVideojuego nVideojuego = new NVideojuego();
        private NDesarrollador nDesarrollador = new NDesarrollador();
        private Videojuego videojuegoSeleccionado = null;

        public VideojuegoWindow()
        {
            InitializeComponent();
            MostrarVideojuegos(nVideojuego.ListarTodo());
            MostrarDesarrolladores(nDesarrollador.ListarTodo());
        }

        private void MostrarVideojuegos(List<Videojuego> videojuegos)
        {
            dgVideojuegos.ItemsSource = new List<Videojuego>();
            dgVideojuegos.ItemsSource = videojuegos;
        }

        private void MostrarDesarrolladores(List<Desarrollador> desarrolladores)
        {
            cbDesarrollador.ItemsSource = new List<Desarrollador>();
            cbDesarrollador.ItemsSource = desarrolladores;
            cbDesarrollador.DisplayMemberPath = "Nombre";
            cbDesarrollador.SelectedValuePath = "Id_Desarrollador";
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbTitulo.Text == "" || cbValoracion.Text == "" || cbDesarrollador.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Videojuego videojuego = new Videojuego
            {
                Titulo = tbTitulo.Text,
                Valoracion = int.Parse(cbValoracion.Text),
                Id_Desarrollador = (int)cbDesarrollador.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nVideojuego.Registrar(videojuego);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarVideojuegos(nVideojuego.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbTitulo.Text == "" || cbValoracion.Text == "" || cbDesarrollador.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (videojuegoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un videojuego");
                return;
            }

            // Creación del objeto
            Videojuego videojuego = new Videojuego
            {
                Id_Videojuego = videojuegoSeleccionado.Id_Videojuego,
                Titulo = tbTitulo.Text,
                Valoracion = int.Parse(cbValoracion.Text),
                Id_Desarrollador = (int)cbDesarrollador.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nVideojuego.Modificar(videojuego);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarVideojuegos(nVideojuego.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            // Validación de selección
            if (videojuegoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un videojuego");
                return;
            }

            // Eliminar
            String mensaje = nVideojuego.Eliminar(videojuegoSeleccionado.Id_Videojuego);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarVideojuegos(nVideojuego.ListarTodo());
        }

        private void btnListarPorValoracion_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (cbValoracion.Text == "")
            {
                MessageBox.Show("Ingrese valoración");
                return;
            }

            // Mostrar en el DataGrid
            MostrarVideojuegos(nVideojuego.ListarTodoPorValoracion(int.Parse(cbValoracion.Text)));
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgVideojuegos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            videojuegoSeleccionado = dgVideojuegos.SelectedItem as Videojuego;
        }
    }
}
