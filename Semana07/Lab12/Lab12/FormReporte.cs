using Lab12.entities;
using Lab12.services;

namespace Lab12
{
    public partial class FormReporte : Form
    {
        private DoctorService doctorService = new();
        private PacienteService pacienteService = new();

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

        private void MostrarDoctores(List<Doctor> lista)
        {
            listViewDoctores.Items.Clear();
            foreach (Doctor doctor in lista)
            {
                ListViewItem fila = new(doctor.NroColegiatura);
                fila.SubItems.Add(doctor.NombreCompleto);
                fila.SubItems.Add(doctor.Especialidad);
                listViewDoctores.Items.Add(fila);
            }
        }

        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnBuscarDoctoresConPacientesConMayorEdad_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.ListarDoctoresConPacientesConMasEdad());
        }

        private void btnBuscarDoctoresConMenosPacientes_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.ListarDoctoresConMenosPacientes());
        }

        private void btnBuscarPacientesPorEspecialidadDelDoctor_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbEspecialidad.Text == "")
            {
                MessageBox.Show("Ingrese especialidad");
                return;
            }

            MostrarPacientes(pacienteService.ListarPacientesPorEspecialidadDoctor(tbEspecialidad.Text));
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
