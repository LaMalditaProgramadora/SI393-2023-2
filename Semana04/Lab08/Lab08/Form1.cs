using Lab08.Modelos;

namespace Lab08
{
    public partial class Form1 : Form
    {
        List<Agencia> agencias = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAgencias(List<Agencia> lista)
        {
            listViewAgencias.Items.Clear();
            foreach (Agencia agencia in lista)
            {
                ListViewItem fila = new(agencia.Codigo);
                fila.SubItems.Add(agencia.Direccion);
                fila.SubItems.Add(agencia.Ciudad);
                fila.SubItems.Add(agencia.Telefono);
                listViewAgencias.Items.Add(fila);
            }
        }

        private void MostrarInmuebles(List<Inmueble> lista)
        {
            listViewInmuebles.Items.Clear();
            double montoTotalAlquiler = 0;
            foreach (Inmueble inmueble in lista)
            {
                if (inmueble.Condicion.Equals("Alquiler"))
                {
                    montoTotalAlquiler += inmueble.Precio;
                }

                ListViewItem fila = new(inmueble.Codigo);
                fila.SubItems.Add(inmueble.Direccion);
                fila.SubItems.Add(inmueble.Superficie.ToString());
                fila.SubItems.Add(inmueble.Precio.ToString());
                fila.SubItems.Add(inmueble.Condicion);
                listViewInmuebles.Items.Add(fila);
            }
            lblMontoTotalAlquilerInmuebles.Text = montoTotalAlquiler.ToString();
        }

        private void btnAgregarAgencia_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbAgenciaCodigo.Text == "" || tbAgenciaDireccion.Text == "" ||
                tbAgenciaCiudad.Text == "" || tbAgenciaTelefono.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de código
            bool existe = agencias.Exists(a => a.Codigo.Equals(tbAgenciaCodigo.Text));
            if (existe)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Crear el objeto
            Agencia agencia = new()
            {
                Codigo = tbAgenciaCodigo.Text,
                Direccion = tbAgenciaDireccion.Text,
                Ciudad = tbAgenciaCiudad.Text,
                Telefono = tbAgenciaTelefono.Text,
                Inmuebles = new()
            };

            // Agregar a la lista
            agencias.Add(agencia);

            // Mostrar en el ListView
            MostrarAgencias(agencias);
        }

        private void btnLimpiarAgencia_Click(object sender, EventArgs e)
        {
            // Mostrar en el ListView
            MostrarAgencias(agencias);
        }

        private void btnAgregarInmueble_Click(object sender, EventArgs e)
        {
            // Validación de agencia seleccionada
            if (listViewAgencias.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una agencia");
                return;
            }

            // Validación de campos
            if (tbInmuebleCodigo.Text == "" || tbInmuebleDireccion.Text == "" ||
                tbInmuebleSuperficie.Text == "" || tbInmueblePrecio.Text == "" ||
                cbInmuebleCondicion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de código
            String codigo = tbInmuebleCodigo.Text;
            foreach (Agencia agencia in agencias)
            {
                bool existe = agencia.Inmuebles.Exists(i => i.Codigo.Equals(codigo));
                if (existe)
                {
                    MessageBox.Show("El código ya existe");
                    return;
                }
            }

            // Buscamos la agencia seleccionada
            String codigoAgencia = listViewAgencias.SelectedItems[0].Text;
            Agencia? agenciaSelec = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            if (agenciaSelec != null)
            {
                // Crear el objeto
                Inmueble inmueble = new()
                {
                    Codigo = tbInmuebleCodigo.Text,
                    Direccion = tbInmuebleDireccion.Text,
                    Superficie = double.Parse(tbInmuebleSuperficie.Text),
                    Precio = double.Parse(tbInmueblePrecio.Text),
                    Condicion = cbInmuebleCondicion.Text
                };

                // Agregar a lista
                agenciaSelec.Inmuebles.Add(inmueble);

                // Mostrar en el ListView
                MostrarInmuebles(agenciaSelec.Inmuebles);
            }

        }

        private void btnLimpiarInmueble_Click(object sender, EventArgs e)
        {
            // Mostrar en el ListView
            MostrarInmuebles(new List<Inmueble>());
        }

        private void listViewAgencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validación de agencia seleccionada
            if (listViewAgencias.SelectedItems.Count == 0)
            {
                return;
            }

            // Buscamos la agencia seleccionada
            String codigoAgencia = listViewAgencias.SelectedItems[0].Text;
            Agencia? agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            if (agencia != null)
            {
                // Mostrar en el ListView
                MostrarInmuebles(agencia.Inmuebles);
            }
        }

        private void btnAgenciasAlquilerInmueblesMayorSuperficie_Click(object sender, EventArgs e)
        {
            // Buscamos las que alquilan los inmuebles con mayor superficie (por agencia)
            List<Agencia> agenciasTemp = new();
            double maxSuperficie = 0;
            foreach (Agencia agencia in agencias)
            {
                Inmueble? inmuebleMaxSuperficie = agencia.Inmuebles.MaxBy(i => i.Superficie);
                if (inmuebleMaxSuperficie != null)
                {
                    if (inmuebleMaxSuperficie.Superficie > maxSuperficie)
                    {
                        maxSuperficie = inmuebleMaxSuperficie.Superficie;
                        agenciasTemp.Clear();
                        agenciasTemp.Add(agencia);
                    }
                    else if (inmuebleMaxSuperficie.Superficie == maxSuperficie)
                    {
                        agenciasTemp.Add(agencia);
                    }
                }
            }

            // Mostrar en el ListView
            MostrarAgencias(agenciasTemp);
        }

        private void btnAgenciasMayorCantidadInmueblesVenta_Click(object sender, EventArgs e)
        {
            // Buscamos las tienen la mayor cantidad de inmuebles a la venta
            List<Agencia> agenciasTemp = new();
            int maxInmueblesVenta = 0;
            foreach (Agencia agencia in agencias)
            {
                int inmueblesVenta = (agencia.Inmuebles.FindAll(i => i.Condicion.Equals("Venta"))).Count;
                if (inmueblesVenta > maxInmueblesVenta)
                {
                    maxInmueblesVenta = inmueblesVenta;
                    agenciasTemp.Clear();
                    agenciasTemp.Add(agencia);
                }
                else if (inmueblesVenta == maxInmueblesVenta)
                {
                    agenciasTemp.Add(agencia);
                }
            }

            // Mostrar en el ListView
            MostrarAgencias(agenciasTemp);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese código de agencia");
                return;
            }

            // Buscamos la agencia seleccionada
            Agencia? agenciaSelec = agencias.Find(a => a.Codigo.Equals(tbBuscar.Text));

            if (agenciaSelec != null)
            {
                // Buscamos los inmuebles en venta
                List<Inmueble> inmueblesTemp = agenciaSelec.Inmuebles.FindAll(i => i.Condicion.Equals("Venta"));

                // Mostrar en el ListView
                MostrarInmuebles(inmueblesTemp);
            }
        }
    }
}