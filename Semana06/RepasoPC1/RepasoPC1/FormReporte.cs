using RepasoPC1.entities;
using RepasoPC1.repositories;
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
        private BusService busService = new();
        private RutaService rutaService = new();

        public FormReporte()
        {
            InitializeComponent();
        }

        private bool ExistenCamposVacios()
        {
            return (tbBusConductor.Text == "");
        }

        private void MostrarBuses(List<Bus> lista)
        {
            dgvBuses.DataSource = new();
            dgvBuses.DataSource = lista;
        }

        private void MostrarRutas(List<Ruta> lista)
        {
            dgvRutas.DataSource = new();
            dgvRutas.DataSource = lista;
        }

        private void btnBuscarBusesRutasMasLargas_Click(object sender, EventArgs e)
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
            if (ExistenCamposVacios())
            {
                MessageBox.Show("Ingrese el nombre del conductor");
                return;
            }

            // Mostrar en DataGridView
            List<Ruta> rutasTemp = rutaService.ListarRutasPorConductorBus(tbBusConductor.Text);
            MostrarRutas(rutasTemp);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
