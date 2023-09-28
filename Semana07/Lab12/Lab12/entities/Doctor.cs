namespace Lab12.entities
{
    internal class Doctor
    {
        public Doctor() { }
        public String NroColegiatura {  get; set; }
        public String NombreCompleto { get; set; }
        public String Especialidad { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}
