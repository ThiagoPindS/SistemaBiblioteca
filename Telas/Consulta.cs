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

            AtualiazarAcervo();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvAcervo.CurrentRow.Cells[1].Value = txtTitulo.Text;
            dgvAcervo.CurrentRow.Cells[2].Value = txtAutor.Text;
            dgvAcervo.CurrentRow.Cells[3].Value = txtAnoDaPublicacao.Text;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Cadastrar.instance.livros.RemoveAt(dgvAcervo.CurrentRow.Index);

            dgvAcervo.Rows.Remove(dgvAcervo.CurrentRow);
        }

        private void btnAlterarStatus_Click(object sender, EventArgs e)
        {
            //var statusSelecionado = dgvAcervo.SelectedCells[0];

            if (dgvAcervo.SelectedCells[0].Value == "Disponível")
            {
                dgvAcervo.SelectedCells[0].Value = "Emprestado";
            }
            else if (dgvAcervo.SelectedCells[0].Value == "Emprestado")
            {
                dgvAcervo.SelectedCells[0].Value = "Disponível";
            }
            else
            {
                MessageBox.Show("Selecione a opção status");
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
            string status = cbxStatus.Text;

            switch (status)
            {
                case "Todos":
                    {
                        AtualiazarAcervo();
                    }
                    break;
                case "Disponível":
                    {
                        AtualiazarAcervo();
                    }
                    break;
                case "Emprestado":
                    {
                        AtualiazarAcervo();
                    }
                    break;
            }
        }

        public void LimparAcervo()
        {
            dgvAcervo.Rows.Clear();
        }

        public void AtualiazarAcervo()
        {
            LimparAcervo();

            for (int i = 0; i < Cadastrar.instance.livros.Count; i++)
            {
                if (Cadastrar.instance.livros[i].Status == cbxStatus.Text)
                {
                    string[] linha = new string[] { Cadastrar.instance.livros[i].ID.ToString(), Cadastrar.instance.livros[i].Titulo, Cadastrar.instance.livros[i].Autor, Cadastrar.instance.livros[i].AnoDaPublicacao, Cadastrar.instance.livros[i].Status };

                    dgvAcervo.Rows.Add(linha);
                }
                else if (cbxStatus.Text == "Todos")
                {
                    string[] linha = new string[] { Cadastrar.instance.livros[i].ID.ToString(), Cadastrar.instance.livros[i].Titulo, Cadastrar.instance.livros[i].Autor, Cadastrar.instance.livros[i].AnoDaPublicacao, Cadastrar.instance.livros[i].Status };

                    dgvAcervo.Rows.Add(linha);
                }
            }
        }
    }
}
