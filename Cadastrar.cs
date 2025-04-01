using Prova_POO_Abril_Ian_Pereira.Classes;

namespace Prova_POO_Abril_Ian_Pereira
{
    public partial class Cadastrar : Form
    {
        List<Livro> livros = new List<Livro>();
        public Cadastrar()
        {
            InitializeComponent();
        }
        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            livros.Add(new Livro() { Titulo = txtTitulo.Text, Autor = txtAutor.Text, AnoDaPublicacao = txtAno.Text, Emprestado = cbxStatus.SelectedText });
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAno.Clear();
            txtAutor.Clear();
            cbxStatus.SelectedItem = null;
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
    }
}
