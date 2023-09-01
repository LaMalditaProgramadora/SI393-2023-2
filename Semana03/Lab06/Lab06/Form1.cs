namespace Lab06
{
    public partial class Form1 : Form
    {
        List<Album> albumes = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlbumes(List<Album> lista)
        {
            listViewAlbum.Items.Clear();
            foreach (Album album in lista)
            {
                ListViewItem fila = new(album.Codigo);
                fila.SubItems.Add(album.Nombre);
                listViewAlbum.Items.Add(fila);
            }

            // Obtener el álbum con más héroes
            Album? albumMasHeroes = lista.MaxBy(element => element.Heroes.Count);
            if (albumMasHeroes != null) lblAlbumMasHeroes.Text = albumMasHeroes.Nombre;
        }

        private void MostrarHeroes(List<Heroe> lista)
        {
            listViewHeroe.Items.Clear();
            foreach (Heroe heroe in lista)
            {
                ListViewItem fila = new(heroe.Codigo);
                fila.SubItems.Add(heroe.Nombre);
                fila.SubItems.Add(heroe.Caracteristicas);
                fila.SubItems.Add(heroe.Poder.ToString());
                listViewHeroe.Items.Add(fila);
            }

            // Obtener el héroes con mayor y menos poder
            Heroe? heroeMayorPoder = lista.MaxBy(element => element.Poder);
            Heroe? heroeMenorPoder = lista.MaxBy(element => element.Poder);
            if (heroeMayorPoder != null) lblHeroeMayorPoder.Text = heroeMayorPoder.Nombre;
            if (heroeMenorPoder != null) lblHeroeMenorPoder.Text = heroeMenorPoder.Nombre;
        }

        private void btnRegistrarAlbum_Click(object sender, EventArgs e)
        {
            // Validar
            if (tbAlbumCodigo.Text == "" || tbAlbumNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos del álbum");
                return;
            }
            bool exist = albumes.Exists(element => element.Codigo.Equals(tbAlbumCodigo.Text));
            if (exist)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }

            // Crear objeto
            Album album = new()
            {
                Codigo = tbAlbumCodigo.Text,
                Nombre = tbAlbumNombre.Text,
                Heroes = new()
            };

            // Agregar al listado de albumes
            albumes.Add(album);

            // Mostrar en el ListView y ComboBox
            MostrarAlbumes(albumes);
        }

        private void bRegistrarHeroe_Click(object sender, EventArgs e)
        {
            // Validar
            bool seleccionado = listViewAlbum.SelectedItems.Count != 0;
            if (!seleccionado || tbHeroeCodigo.Text == "" || tbHeroeNombre.Text == "" ||
                tbHeroeCaracteristicas.Text == "" || tbHeroePoder.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos del héroe");
                return;
            }

            // Hallamos el álbum seleccionado
            Album? albumSeleccionado =
                albumes.Find(element => element.Codigo.Equals(listViewAlbum.SelectedItems[0].Text));
            if (albumSeleccionado == null)
            {
                return;
            }

            // Hallamos la lista de héroes del álbum
            List<Heroe> heroes = albumSeleccionado.Heroes;
            bool exist = heroes.Exists(element => element.Codigo.Equals(tbHeroeCodigo.Text));
            if (exist)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }

            // Crear objeto
            Heroe heroe = new()
            {
                Codigo = tbHeroeCodigo.Text,
                Nombre = tbHeroeNombre.Text,
                Caracteristicas = tbHeroeCaracteristicas.Text,
                Poder = double.Parse(tbHeroePoder.Text)
            };

            // Agregar al listado de héroes del álbum
            albumSeleccionado.Heroes.Add(heroe);

            // Mostrar en el ListView
            MostrarHeroes(heroes);
        }

        private void btnLimpiarAlbum_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(albumes);
        }

        private void btnLimpiarHeroes_Click(object sender, EventArgs e)
        {
            MostrarHeroes(new List<Heroe>());
        }

        private void listViewAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar que esté seleccionado
            bool seleccionado = listViewAlbum.SelectedItems.Count != 0;
            if (!seleccionado)
            {
                return;
            }

            // Hallamos el álbum seleccionado
            Album? albumSeleccionado =
                albumes.Find(element => element.Codigo.Equals(listViewAlbum.SelectedItems[0].Text));
            if (albumSeleccionado == null)
            {
                return;
            }

            // Mostramos sus héroes
            MostrarHeroes(albumSeleccionado.Heroes);
        }

        private void listViewHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar que esté seleccionado
            bool seleccionado = listViewHeroe.SelectedItems.Count != 0;
            if (!seleccionado)
            {
                return;
            }

            // Hallamos el código del héroe seleccionado
            String codigo = listViewHeroe.SelectedItems[0].Text;

            // Buscamos si los álbumes contienen un héroe con ese código
            // Y Almacenamos en un temporal
            List<Album> albumesTemp = new();
            foreach (Album album in albumes)
            {
                bool exist = album.Heroes.Exists(elemento => elemento.Codigo.Equals(codigo));
                if (exist) albumesTemp.Add(album);
            }

            // Mostramos sus álbumes
            MostrarAlbumes(albumesTemp);
        }
    }
}