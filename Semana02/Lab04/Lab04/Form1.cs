using System.Collections;

namespace Lab04
{
    public partial class Form1 : Form
    {
        Alumno[] alumnos = new Alumno[100];
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            // Validación
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" || textBoxPromedio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Alumno alumno = new Alumno();
            alumno.Codigo = textBoxCodigo.Text;
            alumno.Nombre = textBoxNombre.Text;
            alumno.Promedio = double.Parse(textBoxPromedio.Text);

            // Agregar el objeto al arreglo
            alumnos[cont] = alumno;
            cont++;
        }

        private void mostrar(Alumno[] arreglo, int cantidad)
        {
            listViewAlumnos.Items.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                ListViewItem fila = new ListViewItem(arreglo[i].Codigo);
                fila.SubItems.Add(arreglo[i].Nombre);
                fila.SubItems.Add(arreglo[i].Promedio.ToString());
                listViewAlumnos.Items.Add(fila);
            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            mostrar(alumnos, cont);
        }

        private class Metodo_Comparacion : IComparer
        {
            int IComparer.Compare(object? x, object? y)
            {
                double promedio1 = ((Alumno)x).Promedio;
                double promedio2 = ((Alumno)y).Promedio;

                if (promedio1 < promedio2) return 1;
                else return -1;
            }
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(alumnos, 0, cont, new Metodo_Comparacion());
            mostrar(alumnos, cont);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (listViewAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            // Obtener la posición
            // Lambda: elemento => condición del elemento
            int pos = Array.FindIndex(alumnos, alumno => alumno.Codigo == listViewAlumnos.SelectedItems[0].Text);

            // Lógica de la eliminación
            for (int i = 0; i < cont; i++)
            {
                if (i >= pos)
                {
                    alumnos[i] = alumnos[i + 1];
                }
            }
            cont--;
            mostrar(alumnos, cont);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Validación
            if (textBoxBusqueda.Text == "") {
                MessageBox.Show("Inserte código a buscar");
                return;
            }
            Alumno[] alumnosTmp = Array.FindAll(alumnos, alumno => alumno != null && textBoxBusqueda.Text == alumno.Codigo);
            mostrar(alumnosTmp, alumnosTmp.Length);
        }
    }
}