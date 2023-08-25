using System.Drawing.Imaging;

namespace pjEmpresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creando al empleado
            Empleado empl = new Empleado();
            empl.Nombre = textBoxNombre.Text;
            empl.Categoria = comboBoxCategoria.Text;
            empl.MinutosTardanza = int.Parse(textBoxMinutosTardanza.Text);
            empl.LlamadasAtencion = int.Parse(textBoxLlamadasAtencion.Text);

            // Definir el pago base
            switch (empl.Categoria)
            {
                case "A": empl.Pago = 2500; break;
                case "B": empl.Pago = 1500; break;
                case "C": empl.Pago = 1000; break;
                case "D": empl.Pago = 900; break;
            }

            // Aumento/Descuento
            if (empl.MinutosTardanza == 0 && empl.LlamadasAtencion == 0)
            {
                empl.Pago = empl.Pago * 1.15;
            }
            else
            {
                double descMinutosTardanza = empl.MinutosTardanza * 5;
                double descLlamadasAtencion = empl.LlamadasAtencion * 10;
                empl.Pago = empl.Pago - descMinutosTardanza - descLlamadasAtencion;
            }

            // Agregar todo al ListView
            ListViewItem fila = new ListViewItem(empl.Nombre);
            fila.SubItems.Add(empl.Categoria);
            fila.SubItems.Add(empl.MinutosTardanza.ToString());
            fila.SubItems.Add(empl.LlamadasAtencion.ToString());
            fila.SubItems.Add(empl.Pago.ToString());
            listViewEmpleados.Items.Add(fila);

            // Actualizar el total
            labelTotal.Text = (int.Parse(labelTotal.Text) + 1).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}