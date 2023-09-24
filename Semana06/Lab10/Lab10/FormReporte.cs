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
    public partial class FormReporte : Form
    {
        private BusService busService = new();
        private RutaService rutaService = new();

        private void MostrarRutas(List<Ruta> lista)
        {
            listViewRutas.Items.Clear();
            foreach (Ruta ruta in lista)
            {
                ListViewItem fila = new(ruta.Codigo);
                fila.SubItems.Add(ruta.Origen);
                fila.SubItems.Add(ruta.Destino);
                fila.SubItems.Add(ruta.Kilometros.ToString());
                listViewRutas.Items.Add(fila);
            }
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

        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnBuscarBusesConRutasMasLargas_Click(object sender, EventArgs e)
        {
            MostrarBuses(busService.ListarBusesConRutasMasLargas());
        }

        private void btnBuscarBusesConMenosRutas_Click(object sender, EventArgs e)
        {
            MostrarBuses(busService.ListarBusesConMenosRutas());
        }

        private void btnBuscarRutasPorConductorBus_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbConductor.Text == "")
            {
                MessageBox.Show("Ingrese conductor");
                return;
            }

            MostrarRutas(rutaService.ListarRutasPorConductorBus(tbConductor.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
