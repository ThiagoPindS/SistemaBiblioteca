using Prova_POO_Abril_Ian_Pereira.Classes;

namespace Prova_POO_Abril_Ian_Pereira
{
    public partial class Cadastrar : Form
    {
        public static Cadastrar instance;

        public List<Livro> livros = new List<Livro>();

        public Cadastrar()
        {
            InitializeComponent();

            instance = this;
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "" && txtAutor.Text != "" && txtAno.Text != "" && cbxStatus.SelectedItem.ToString() != "")
            {
                livros.Add(new Livro() { ID = livros.Count, Titulo = txtTitulo.Text, Autor = txtAutor.Text, AnoDaPublicacao = txtAno.Text, Status = cbxStatus.SelectedItem.ToString() });

                MessageBox.Show("Livro cadastrado com sucesso");

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Dados insuficientes para cadastro");
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta consulta = new Consulta();
            consulta.ShowDialog();

            if (consulta != null)
            {
                this.Show();
            }
        }

        public void LimparCampos()
        {
            txtTitulo.Clear();
            txtAno.Clear();
            txtAutor.Clear();
            cbxStatus.SelectedItem = null;
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Digite apenas números");
            }
        }
    }
}
