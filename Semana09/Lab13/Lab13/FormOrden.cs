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
    public partial class FormOrden : Form
    {
        private OrdenService oService = new OrdenService();
        private String placa;
        public FormOrden(String placa)
        {
            InitializeComponent();
            this.placa = placa;
        }

        private void MostrarOrdenes(List<Orden> ordenes)
        {
            listViewOrdenes.Items.Clear();
            foreach (Orden orden in ordenes)
            {
                ListViewItem fila = new ListViewItem(orden.Codigo);
                fila.SubItems.Add(orden.NombreServicio);
                fila.SubItems.Add(orden.NombreCliente);
                fila.SubItems.Add(orden.Monto.ToString());
                fila.SubItems.Add(orden.FechaServicio);
                listViewOrdenes.Items.Add(fila);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || cbNombreServicio.Text == "" || tbNombreCliente.Text == "" ||
                tbMonto.Text == "" || tbFechaServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Orden orden = new Orden()
            {
                Codigo = tbCodigo.Text,
                NombreServicio = cbNombreServicio.Text,
                NombreCliente = tbNombreCliente.Text,
                Monto = double.Parse(tbMonto.Text),
                FechaServicio = tbFechaServicio.Text
            };

            // Registro
            bool registrado = oService.Registrar(placa, orden);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un código diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarOrdenes(oService.ListarTodo(placa));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
