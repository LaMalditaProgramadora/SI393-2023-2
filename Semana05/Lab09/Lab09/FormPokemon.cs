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
    public partial class FormPokemon : Form
    {
        private PokemonService pokemonService = new();
        private String codigoEntrenador;
        public FormPokemon(String codigoEntrenador)
        {
            InitializeComponent();
            this.codigoEntrenador = codigoEntrenador;
            Mostrar(pokemonService.ListarPorEntrenador(codigoEntrenador));
        }

        private void Mostrar(List<Pokemon> lista)
        {
            listViewPokemon.Items.Clear();
            int totalPuntoSalud = 0;
            foreach (Pokemon en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Apodo);
                fila.SubItems.Add(en.Tipo);
                fila.SubItems.Add(en.PuntosSalud.ToString());
                fila.SubItems.Add(en.Legendario.ToString());
                listViewPokemon.Items.Add(fila);
                totalPuntoSalud += en.PuntosSalud;
            }
            lblTotalPokemon.Text = lista.Count.ToString();
            lblTotalPsPokemon.Text = totalPuntoSalud.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbApodo.Text == "" || cbTipo.Text == "" || tbPs.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Pokemon pokemon = new()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Apodo = tbApodo.Text,
                Tipo = cbTipo.Text,
                PuntosSalud = int.Parse(tbPs.Text),
                Legendario = chBEsLegendario.Checked
            };

            // Insertar
            bool insertado = pokemonService.Insertar(codigoEntrenador, pokemon);
            if (!insertado)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Actualizar ListView
            Mostrar(pokemonService.ListarPorEntrenador(codigoEntrenador));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
