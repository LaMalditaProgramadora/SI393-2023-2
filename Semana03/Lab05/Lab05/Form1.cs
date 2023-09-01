namespace Lab05
{
    public partial class Form1 : Form
    {
        private List<Electrodomestico> electrodomesticos = new();
        private List<Electrodomestico> electrodomesticosBusqueda = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar(List<Electrodomestico> lista)
        {
            listViewElectrodomesticos.Items.Clear();
            int contadorStock = 0;

            foreach (Electrodomestico elec in lista)
            {
                ListViewItem fila = new(elec.Codigo);
                fila.SubItems.Add(elec.Nombre);
                fila.SubItems.Add(elec.Stock.ToString());
                fila.SubItems.Add(elec.Precio.ToString());
                listViewElectrodomesticos.Items.Add(fila);

                contadorStock += elec.Stock;
            }

            // Actualizamos los totales
            labelTotalRegistros.Text = lista.Count.ToString();
            labelTotalStock.Text = contadorStock.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == ""
                || numericUpDownStock.Text == "" || textBoxPrecio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Verificamos si el código ya está registrado
            bool existe = electrodomesticos.Exists(ele => ele.Codigo.Equals(textBoxCodigo.Text));
            if (existe)
            {
                MessageBox.Show("El código del electrodoméstico ya está previamente registrado");
                return;
            }

            // Creamos el electrodoméstico
            Electrodomestico elec = new()
            {
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                Stock = (int)numericUpDownStock.Value,
                Precio = double.Parse(textBoxPrecio.Text)
            };

            // Agregar electrodoméstico a la lista
            electrodomesticos.Add(elec);

            // Actualizamos el ListView
            Mostrar(electrodomesticos);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (listViewElectrodomesticos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione electrodoméstico a eliminar");
                return;
            }

            // Obtenermos el código del electrodoméstico seleccionado
            String codigo = listViewElectrodomesticos.SelectedItems[0].Text;

            // Encontramos el electrodoméstico con ese código y lo eliminamos
            electrodomesticos.RemoveAll(elec => elec.Codigo.Equals(codigo));

            // Actualizamos el ListView
            Mostrar(electrodomesticos);
        }

        private void buttonEliminarTodo_Click(object sender, EventArgs e)
        {
            // Eliminamos todos los electrodomésticos
            electrodomesticos.Clear();

            // Actualizamos el ListView
            Mostrar(electrodomesticos);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Validación
            if (textBoxBusqueda.Text == "")
            {
                MessageBox.Show("Ingrese nombre de electrodoméstico");
                return;
            }

            // Buscamos el electrodoméstico
            electrodomesticosBusqueda = electrodomesticos.FindAll(elec => elec.Nombre.Contains(textBoxBusqueda.Text));

            // Actualizamos el ListView
            Mostrar(electrodomesticosBusqueda);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiamos el cuadro de búsqueda
            textBoxBusqueda.Text = "";
            // Actualizamos el ListView
            Mostrar(electrodomesticos);
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            // Creamos el método para comparar y usamos Sort
            electrodomesticos.Sort((e1, e2) => {
                if (e1.Precio < e2.Precio) return 1;
                else return -1;
            });

            // Actualizamos el ListView
            Mostrar(electrodomesticos);
        }
    }
}