using Lab09.entities;
using Lab09.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09
{
    public partial class FormEntrenador : Form
    {
        private EntrenadorService entrenadorService = new();
        public FormEntrenador()
        {
            InitializeComponent();
            Mostrar(entrenadorService.ListarTodo());
        }

        private void Mostrar(List<Entrenador> lista)
        {
            listViewEntrenador.Items.Clear();
            foreach (Entrenador en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Edad.ToString());
                fila.SubItems.Add(en.Region);
                listViewEntrenador.Items.Add(fila);
            }
            lblTotalEntrenadores.Text = lista.Count.ToString();
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbEdad.Text == "" || cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Entrenador entrenador = new()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Edad = int.Parse(tbEdad.Text),
                Region = cbRegion.Text,
                Pokemons = new List<Pokemon>()
            };

            // Insertar
            bool insertado = entrenadorService.Insertar(entrenador);
            if (!insertado)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Actualizar ListView
            Mostrar(entrenadorService.ListarTodo());
        }

        private void btnVerPokemon_Click(object sender, EventArgs e)
        {
            // Validar selección
            if (listViewEntrenador.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un entrenador");
                return;
            }

            // Abrir formulario de Pokémon enviando el código del entrenador
            FormPokemon form = new(listViewEntrenador.SelectedItems[0].Text);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
