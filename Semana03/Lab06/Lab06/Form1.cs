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

            // Obtener el �lbum con m�s h�roes
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

            // Obtener el h�roes con mayor y menos poder
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
                MessageBox.Show("Ingrese todos los campos del �lbum");
                return;
            }
            bool exist = albumes.Exists(element => element.Codigo.Equals(tbAlbumCodigo.Text));
            if (exist)
            {
                MessageBox.Show("C�digo ya registrado");
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
                MessageBox.Show("Ingrese todos los campos del h�roe");
                return;
            }

            // Hallamos el �lbum seleccionado
            Album? albumSeleccionado =
                albumes.Find(element => element.Codigo.Equals(listViewAlbum.SelectedItems[0].Text));
            if (albumSeleccionado == null)
            {
                return;
            }

            // Hallamos la lista de h�roes del �lbum
            List<Heroe> heroes = albumSeleccionado.Heroes;
            bool exist = heroes.Exists(element => element.Codigo.Equals(tbHeroeCodigo.Text));
            if (exist)
            {
                MessageBox.Show("C�digo ya registrado");
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

            // Agregar al listado de h�roes del �lbum
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
            // Validar que est� seleccionado
            bool seleccionado = listViewAlbum.SelectedItems.Count != 0;
            if (!seleccionado)
            {
                return;
            }

            // Hallamos el �lbum seleccionado
            Album? albumSeleccionado =
                albumes.Find(element => element.Codigo.Equals(listViewAlbum.SelectedItems[0].Text));
            if (albumSeleccionado == null)
            {
                return;
            }

            // Mostramos sus h�roes
            MostrarHeroes(albumSeleccionado.Heroes);
        }

        private void listViewHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar que est� seleccionado
            bool seleccionado = listViewHeroe.SelectedItems.Count != 0;
            if (!seleccionado)
            {
                return;
            }

            // Hallamos el c�digo del h�roe seleccionado
            String codigo = listViewHeroe.SelectedItems[0].Text;

            // Buscamos si los �lbumes contienen un h�roe con ese c�digo
            // Y Almacenamos en un temporal
            List<Album> albumesTemp = new();
            foreach (Album album in albumes)
            {
                bool exist = album.Heroes.Exists(elemento => elemento.Codigo.Equals(codigo));
                if (exist) albumesTemp.Add(album);
            }

            // Mostramos sus �lbumes
            MostrarAlbumes(albumesTemp);
        }
    }
}