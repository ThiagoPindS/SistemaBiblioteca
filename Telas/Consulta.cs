using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prova_POO_Abril_Ian_Pereira.Classes;

namespace Prova_POO_Abril_Ian_Pereira
{
    public partial class Consulta : Form
    {
        public static Consulta instance;

        public Consulta()
        {
            InitializeComponent();

            instance = this;

            AcervoDeLivros.CarregarAcervo();

            AcervoDeLivros.ExibirAcervo("Todos");
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja editar esse livro?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                dgvAcervo.CurrentRow.Cells[1].Value = txtTitulo.Text;
                dgvAcervo.CurrentRow.Cells[2].Value = txtAutor.Text;
                dgvAcervo.CurrentRow.Cells[3].Value = txtAnoDaPublicacao.Text;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAcervo.CurrentRow != null)
            {
                var result = MessageBox.Show("Tem certeza que deseja remover este livro?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    AcervoDeLivros.ExcluirLivro(dgvAcervo.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado para remoção.", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnAlterarStatus_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja altrar o status desse livro?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dgvAcervo.CurrentRow.Cells[4].Value == "Disponível")
                {
                    dgvAcervo.CurrentRow.Cells[4].Value = "Emprestado";
                }
                else
                {
                    dgvAcervo.CurrentRow.Cells[4].Value = "Disponível";
                }
            }
        }

        private void dgvAcervo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitulo.Text = dgvAcervo.CurrentRow.Cells[1].Value.ToString();
            txtAutor.Text = dgvAcervo.CurrentRow.Cells[2].Value.ToString();
            txtAnoDaPublicacao.Text = dgvAcervo.CurrentRow.Cells[3].Value.ToString();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcervoDeLivros.ExibirAcervo(cbxStatus.Text);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            AcervoDeLivros.ExibirAcervo("FiltroPesquisa");
        }
    }
}
