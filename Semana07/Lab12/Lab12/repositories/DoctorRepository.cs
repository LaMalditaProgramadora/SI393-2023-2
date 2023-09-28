using Lab12.entities;

namespace Lab12.repositories
{
    internal class DoctorRepository
    {
        private static List<Doctor> doctores = new();

        public DoctorRepository() { }

        public bool Existe(String NroColegiatura)
        {
            return doctores.Exists(doctor => doctor.NroColegiatura.Equals(NroColegiatura));
        }

        public void Registrar(Doctor doctor)
        {
            doctores.Add(doctor);
        }

        public static List<Doctor> ListarTodo()
        {
            return doctores;
        }

        public List<Doctor> ListarDoctoresConPacientesConMasEdad() {
            List<Doctor> doctoresTemp = new();
            int maxEdad = int.MinValue;
            foreach (Doctor doctor in doctores)
            {
                Paciente? pacienteConMasEdad = doctor.Pacientes.MaxBy(pa => pa.Edad);
                if (pacienteConMasEdad != null) {
                    if (pacienteConMasEdad.Edad > maxEdad)
                    {
                        maxEdad = pacienteConMasEdad.Edad;
                        doctoresTemp.Clear();
                        doctoresTemp.Add(doctor);
                    }
                    else if (pacienteConMasEdad.Edad == maxEdad)
                    {
                        doctoresTemp.Add(doctor);
                    }
                }
            }
            return doctoresTemp;
        }

        public List<Doctor> ListarDoctoresConMenosPacientes() {
            List<Doctor> doctoresTemp = new();
            int menorCantidadPacientes = int.MaxValue;
            foreach (Doctor doctor in doctores) {
                int cantidadPacientes = doctor.Pacientes.Count;
                if (cantidadPacientes < menorCantidadPacientes)
                {
                    menorCantidadPacientes = cantidadPacientes;
                    doctoresTemp.Clear();
                    doctoresTemp.Add(doctor);
                }
                else if (cantidadPacientes == menorCantidadPacientes)
                {
                    doctoresTemp.Add(doctor);
                }
            }
            return doctoresTemp;
        }
    }
}
