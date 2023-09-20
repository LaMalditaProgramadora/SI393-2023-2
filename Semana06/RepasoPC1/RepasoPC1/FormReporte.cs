using RepasoPC1.entities;
using RepasoPC1.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoPC1
{
    public partial class FormReporte : Form
    {
        private RutaService rutaService = new();
        private BusService busService = new();

        public FormReporte()
        {
            InitializeComponent();
        }

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

        private void btnBuscarBusesConRutasMasLargas_Click(object sender, EventArgs e)
        {
            List<Bus> busesTemp = busService.ListarBusesConRutasMasLargas();
            MostrarBuses(busesTemp);
        }

        private void btnBuscarBusesConMenosRutas_Click(object sender, EventArgs e)
        {
            List<Bus> busesTemp = busService.ListarBusesConMenosRutas();
            MostrarBuses(busesTemp);
        }

        private void btnBuscarRutasPorConductorBus_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbConductor.Text == "")
            {
                MessageBox.Show("Ingrese conductor");
                return;
            }

            List<Ruta> rutasTemp = rutaService.ListarRutasPorConductorBus(tbConductor.Text);
            MostrarRutas(rutasTemp);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
