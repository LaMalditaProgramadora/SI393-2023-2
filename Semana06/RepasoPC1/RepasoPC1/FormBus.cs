using RepasoPC1.entities;
using RepasoPC1.services;

namespace RepasoPC1
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
            dgvBuses.DataSource = new();
            dgvBuses.DataSource = lista;
        }

        private bool ExistenCamposVacios()
        {
            return (cbBusTipo.Text == "" || tbBusMatricula.Text == "" || tbBusConductor.Text == "");
        }

        private bool BusNoSeleccionado()
        {
            return (dgvBuses.SelectedRows.Count == 0 || dgvBuses.SelectedRows[0].Cells[0].Value == null);
        }

        private void btnBusRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (ExistenCamposVacios())
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Bus bus = new(
                tbBusMatricula.Text,
                cbBusTipo.Text,
                tbBusConductor.Text
                );

            // Registro de bus
            bool insertado = busService.Registrar(bus);
            if (!insertado)
            {
                MessageBox.Show("Ingrese un código diferente");
                return;
            }

            // Mostrar en DataGridView
            MostrarBuses(busService.ListarTodo());
        }

        private void btnVerRutas_Click(object sender, EventArgs e)
        {
            if (BusNoSeleccionado())
            {
                MessageBox.Show("Seleccione un bus");
                return;
            }

            // Buscamos la primera columna de la fila seleccionada
            String? matricula = dgvBuses.SelectedRows[0].Cells[0].Value.ToString();
            if (matricula != null)
            {
                FormRuta form = new(matricula);
                form.Show();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}