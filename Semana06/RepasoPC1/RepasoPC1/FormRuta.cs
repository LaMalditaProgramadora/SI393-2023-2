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
        private String matricula;

        public FormRuta(string matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            MostrarRutas(rutaService.ListarTodo(matricula));
        }

        private void MostrarRutas(List<Ruta> lista)
        {
            dgvRutas.DataSource = new();
            dgvRutas.DataSource = lista;
        }

        private bool ExistenCamposVacios()
        {
            return (tbRutaCodigo.Text == "" || cbRutaDestino.Text == "" ||
                cbRutaDestino.Text == "" || tbRutaKilometros.Text == "");
        }

        private void btnRutaRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (ExistenCamposVacios())
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Ruta ruta = new(
                tbRutaCodigo.Text,
                cbRutaDestino.Text,
                cbRutaDestino.Text,
                Double.Parse(tbRutaKilometros.Text))
                ;

            // Registro de ruta
            bool insertado = rutaService.Registrar(matricula, ruta);
            if (!insertado)
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
