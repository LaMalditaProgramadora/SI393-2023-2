using Lab09.entities;
using Lab09.services;

namespace Lab09
{
    public partial class FormPokemon : Form
    {
        private PokemonService pokemonService;
        public FormPokemon(String codigoEntrenador)
        {
            InitializeComponent();
            pokemonService = new(codigoEntrenador);
            Mostrar(pokemonService.ListarTodo());
        }

        private void Mostrar(List<Pokemon> lista)
        {
            listViewPokemon.Items.Clear();
            int totalPuntoSalud = 0;
            foreach (Pokemon en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Apodo);
                fila.SubItems.Add(en.Tipo);
                fila.SubItems.Add(en.PuntosSalud.ToString());
                fila.SubItems.Add(en.Legendario.ToString());
                listViewPokemon.Items.Add(fila);
                totalPuntoSalud += en.PuntosSalud;
            }
            lblTotalPokemon.Text = lista.Count.ToString();
            lblTotalPsPokemon.Text = totalPuntoSalud.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbApodo.Text == "" || cbTipo.Text == "" || tbPs.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validar si tiene más de 6 pokémos
            if (pokemonService.ListarTodo().Count == 6) {
                MessageBox.Show("No se puede agregar más de 6 pokémons");
                return;
            }

            // Crear el objeto
            Pokemon pokemon = new()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Apodo = tbApodo.Text,
                Tipo = cbTipo.Text,
                PuntosSalud = int.Parse(tbPs.Text),
                Legendario = chBEsLegendario.Checked
            };

            // Insertar
            bool insertado = pokemonService.Insertar(pokemon);
            if (!insertado)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Actualizar ListView
            Mostrar(pokemonService.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
