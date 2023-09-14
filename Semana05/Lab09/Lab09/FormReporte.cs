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
    public partial class FormReporte : Form
    {
        private EntrenadorService entrenadorService = new();
        public FormReporte()
        {
            InitializeComponent();
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

        private void btnBuscarPorNombrePokemon_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            // Listar
            Mostrar(entrenadorService.ListarPorNombrePokemon(tbNombre.Text));
        }

        private void btnBuscarPorRegion_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese la región");
                return;
            }

            // Listar
            Mostrar(entrenadorService.ListarPorRegion(cbRegion.Text));
        }

        private void btnBuscarPorMenorCantPokemon_Click(object sender, EventArgs e)
        {
            // Listar
            Mostrar(entrenadorService.ListarPorMenorCantidadPokemon());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
