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
    public partial class FormVehiculo : Form
    {
        private VehiculoService vService = new VehiculoService();

        public FormVehiculo()
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbPlaca.Text == "" || tbNumTarjetaProp.Text == "" || tbModelo.Text == "" ||
                tbColor.Text == "" || tbNumMotor.Text == "" || tbFechaUltimIngreso.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Vehiculo vehiculo = new Vehiculo()
            {
                Placa = tbPlaca.Text,
                NumeroTarjetaPropiedad = tbNumTarjetaProp.Text,
                Modelo = tbModelo.Text,
                Color = tbColor.Text,
                NumeroMotor = tbNumMotor.Text,
                FechaUltimoIngreso = tbFechaUltimIngreso.Text,
                // Inicializar la lista de órdenes
                Ordenes = new List<Orden>()
            };

            // Registro
            bool registrado = vService.Registrar(vehiculo);
            if (!registrado)
            {
                MessageBox.Show("Ingrese una placa diferente");
                return;
            }

            // Mostrar en ListView
            MostrarVehiculos(vService.ListarTodo());
        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            if (listViewVehiculos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo");
                return;
            }

            // Obtenemos la placa
            String placa = listViewVehiculos.SelectedItems[0].Text;
            FormOrden form = new FormOrden(placa);
            form.Show();
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
