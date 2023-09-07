namespace Lab07
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar(List<Alumno> lista)
        {
            listViewAlumnos.Items.Clear();

            foreach (Alumno alumno in lista)
            {
                ListViewItem fila = new(alumno.Codigo);
                fila.SubItems.Add(alumno.Nombre);
                fila.SubItems.Add(alumno.Dni);
                fila.SubItems.Add(alumno.Edad.ToString());
                listViewAlumnos.Items.Add(fila);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "")
            {
                MessageBox.Show("Ingrese campos");
                return;
            }

            // Creación del objeto
            Alumno alumno = new()
            {
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                Dni = textBoxDni.Text,
                Edad = int.Parse(textBoxEdad.Text)
            };
            alumnos.Add(alumno);
            Mostrar(alumnos);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione alumno");
                return;
            }

            foreach (ListViewItem item in listViewAlumnos.SelectedItems)
            {
                alumnos.RemoveAll(alumno => alumno.Codigo.Equals(item.Text));
            }

            Mostrar(alumnos);
        }
    }
}