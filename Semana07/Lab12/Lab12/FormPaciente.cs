using Lab12.entities;
using Lab12.services;

namespace Lab12
{
    public partial class FormPaciente : Form
    {
        private PacienteService pacienteService = new();
        private String nroColegiatura;

        public FormPaciente(String nroColegiatura)
        {
            InitializeComponent();
            this.nroColegiatura = nroColegiatura;
            MostrarPacientes(pacienteService.ListarTodo(nroColegiatura));
        }

        private void MostrarPacientes(List<Paciente> lista)
        {
            listViewPacientes.Items.Clear();
            foreach (Paciente paciente in lista)
            {
                ListViewItem fila = new(paciente.Dni);
                fila.SubItems.Add(paciente.NombreCompleto);
                fila.SubItems.Add(paciente.Edad.ToString());
                listViewPacientes.Items.Add(fila);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbDni.Text == "" || tbNombreCompleto.Text == "" || tbEdad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Paciente paciente = new()
            {
                Dni = tbDni.Text,
                NombreCompleto = tbNombreCompleto.Text,
                Edad = int.Parse(tbEdad.Text)
            };

            // Registro de paciente
            bool registrado = pacienteService.Registrar(nroColegiatura, paciente);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un dni diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarPacientes(pacienteService.ListarTodo(nroColegiatura));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
