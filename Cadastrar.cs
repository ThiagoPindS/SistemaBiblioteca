namespace Prova_POO_Abril_Ian_Pereira
{
    public partial class Cadastrar : Form
    {
        public Consulta? josoe { get; set; }
        public Cadastrar()
        {
            InitializeComponent();

        }

        private void Cadastrar_Load_1(object sender, EventArgs e)
        {
            josoe = new Consulta();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAno.Clear();
            txtAutor.Clear();
            cbxStatus.SelectedItem = null;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            josoe.ShowDialog();
            //this.Show();
        }
    }
}
