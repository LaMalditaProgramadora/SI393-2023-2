namespace Lab03
{
    public partial class Form1 : Form
    {
        Atencion[] atenciones = new Atencion[100];
        int cont = 0;
        int totalServicio1 = 0;
        int totalServicio2 = 0;
        int totalServicio3 = 0;
        double montoPromedio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (comboBoxTipoAuto.Text == "" || comboBoxTipoServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación de la atención
            Atencion atencion = new Atencion();
            atencion.TipoAuto = comboBoxTipoAuto.Text;
            atencion.TipoServicio = comboBoxTipoServicio.Text;

            // Asignación de monto
            switch (atencion.TipoServicio)
            {
                case "1":
                    atencion.Monto = 10;
                    totalServicio1++;
                    break;
                case "2":
                    atencion.Monto = 15;
                    totalServicio2++;
                    break;
                case "3":
                    atencion.Monto = 10;
                    totalServicio3++;
                    break;
            }
            if (atencion.TipoAuto == "C") atencion.Monto *= 1.05;

            // Agregar al arreglo
            atenciones[cont] = atencion;
            cont++;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            listViewAtenciones.Items.Clear();
            montoPromedio = 0;

            // Recorre el arreglo
            for (int i = 0; i < cont; i++) {
                ListViewItem fila = new ListViewItem(atenciones[i].TipoAuto);
                fila.SubItems.Add(atenciones[i].TipoServicio);
                fila.SubItems.Add(atenciones[i].Monto.ToString());
                listViewAtenciones.Items.Add(fila);
                montoPromedio += atenciones[i].Monto;
            }

            // Calcula los requerimientos
            montoPromedio = montoPromedio / cont;
            labelMontoPromedio.Text = montoPromedio.ToString();
            labelTotalServicio1.Text = totalServicio1.ToString();
            labelTotalServicio2.Text = totalServicio2.ToString();
            labelTotalServicio3.Text = totalServicio3.ToString();
            int[] totales = { totalServicio1, totalServicio2, totalServicio3 };
            int min = totales.Min();

            // Calcula el servicio mínima demanda
            if (min == totales[0]) labelServicioMinimaDemanda.Text = "Servicio 1";
            else if (min == totales[1]) labelServicioMinimaDemanda.Text = "Servicio 2";
            else labelServicioMinimaDemanda.Text = "Servicio 3";


        }
    }
}