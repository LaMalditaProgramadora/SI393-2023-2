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
using System.Windows.Forms.Design;

namespace RepasoPC1
{
    public partial class FormRuta : Form
    {
        private RutaService rutaService = new();
        String matricula;

        public FormRuta(String matricula)
        {
            this.matricula = matricula;
            InitializeComponent();
            MostrarRutas(rutaService.ListarTodo(matricula));
        }

        private void MostrarRutas(List<Ruta> lista)
        {
            listViewRutas.Items.Clear();
            foreach (Ruta ruta in lista) {
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
            Ruta ruta = new(
                tbCodigo.Text,
                tbOrigen.Text,
                tbDestino.Text,
                Double.Parse(tbKilometros.Text)
                );

            // Registro de ruta
            bool registrado = rutaService.Registrar(matricula, ruta);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un código diferente");
                return;
            }

            // Mostrar en DataGridView
            MostrarRutas(rutaService.ListarTodo(matricula));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
