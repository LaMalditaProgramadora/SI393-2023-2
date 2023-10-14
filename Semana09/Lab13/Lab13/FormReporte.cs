using Lab13.entities;
using Lab13.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class FormReporte : Form
    {
        private VehiculoService vService = new VehiculoService();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarVehiculos(List<Vehiculo> vehiculos)
        {
            listViewVehiculos.Items.Clear();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                ListViewItem fila = new ListViewItem(vehiculo.Placa);
                fila.SubItems.Add(vehiculo.NumeroTarjetaPropiedad);
                fila.SubItems.Add(vehiculo.Modelo);
                fila.SubItems.Add(vehiculo.Color);
                fila.SubItems.Add(vehiculo.NumeroMotor);
                fila.SubItems.Add(vehiculo.FechaUltimoIngreso);
                listViewVehiculos.Items.Add(fila);
            }
        }

        private void btnBuscarVehiculosMasOrdenesEnUltimos2Años_Click(object sender, EventArgs e)
        {
            MostrarVehiculos(vService.ListarVehiculosMasOrdenesUltimos2Años());
        }

        private void btnOrdenarVehiculosAscPlaca_Click(object sender, EventArgs e)
        {
            MostrarVehiculos(vService.OrdenarAscendentePorPlaca());
        }

        private void btnBuscarVehiculosMayorMontoPorNombreServicio_Click(object sender, EventArgs e)
        {
            if (cbNombreServicio.Text == "")
            {
                MessageBox.Show("Seleccione nombre del servicio");
                return;
            }

            MostrarVehiculos(vService.ListarVehiculosMayorMontoPorServicio(cbNombreServicio.Text));
        }

        private void btnBuscarVehiculosMenosOrdenes_Click(object sender, EventArgs e)
        {
            MostrarVehiculos(vService.ListarVehiculosMenosOrdenes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
