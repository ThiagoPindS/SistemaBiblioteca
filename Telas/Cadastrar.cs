using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
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
            AcervoDeLivros.CadastrarLivro(txtTitulo.Text, txtAutor.Text, int.Parse(txtAno.Text), cbxStatus.Text);

            LimparCampos();
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

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Digite apenas números", "Erro", MessageBoxButtons.OK);
            }
        }

        public void LimparCampos()
        {
            txtTitulo.Clear();
            txtAno.Clear();
            txtAutor.Clear();
            cbxStatus.SelectedItem = null;
        }
    }
}
