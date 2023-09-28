namespace Lab12
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerDoctores_Click(object sender, EventArgs e)
        {
            FormDoctor formDoctor = new();
            formDoctor.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
