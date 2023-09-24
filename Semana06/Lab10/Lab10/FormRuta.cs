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
    public partial class FormRuta : Form
    {
        private RutaService rutaService = new();

        private String matricula;
        public FormRuta(String matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            MostrarRutas(rutaService.ListarTodo(matricula));
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

        private bool ExistenCamposVacios()
        {
            return (tbCodigo.Text == "" || tbOrigen.Text == "" || tbDestino.Text == "" || tbKilometros.Text == "");
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
            Ruta ruta = new()
            {
                Codigo = tbCodigo.Text,
                Origen = tbOrigen.Text,
                Destino = tbDestino.Text,
                Kilometros = double.Parse(tbKilometros.Text)
            };

            // Registro de ruta
            bool registrado = rutaService.Registrar(matricula, ruta);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un código diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarRutas(rutaService.ListarTodo(matricula));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
