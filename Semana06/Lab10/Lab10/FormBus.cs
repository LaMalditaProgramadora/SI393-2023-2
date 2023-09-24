using Lab10.entities;
using Lab10.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FormBus : Form
    {
        private BusService busService = new();
        public FormBus()
        {
            InitializeComponent();
            MostrarBuses(busService.ListarTodo());
        }

        private void MostrarBuses(List<Bus> lista)
        {
            listViewBuses.Items.Clear();
            foreach (Bus bus in lista)
            {
                ListViewItem fila = new(bus.Matricula);
                fila.SubItems.Add(bus.Tipo);
                fila.SubItems.Add(bus.Conductor);
                listViewBuses.Items.Add(fila);
            }
        }

        private bool BusNoSeleccionado()
        {
            return (listViewBuses.SelectedItems.Count == 0);
        }

        private bool ExistenCamposVacios()
        {
            return (tbMatricula.Text == "" || cbTipo.Text == "" || tbConductor.Text == "");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (ExistenCamposVacios())
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Bus bus = new()
            {
                Matricula = tbMatricula.Text,
                Tipo = cbTipo.Text,
                Conductor = tbConductor.Text,
                Rutas = new()
            };

            // Registro de bus
            bool registrado = busService.Registrar(bus);
            if (!registrado)
            {
                MessageBox.Show("Ingrese una matrícula diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarBuses(busService.ListarTodo());
        }

        private void btnVerRutas_Click(object sender, EventArgs e)
        {
            if (BusNoSeleccionado())
            {
                MessageBox.Show("Seleccione bus");
                return;
            }

            String matricula = listViewBuses.SelectedItems[0].Text;

            FormRuta formRuta = new(matricula);
            formRuta.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new();
            formReporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
