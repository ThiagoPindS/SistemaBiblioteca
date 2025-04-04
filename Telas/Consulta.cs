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

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
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

        public void AtualiazarAcervo()
        {
            for(int i = 0; i < Cadastrar.instance.livros.Count; i++)
            {
                string[] linha = new string[] { Cadastrar.instance.livros[i].ID.ToString(), Cadastrar.instance.livros[i].Titulo, Cadastrar.instance.livros[i].Autor, Cadastrar.instance.livros[i].AnoDaPublicacao, Cadastrar.instance.livros[i].Status };

                dgvAcervo.Rows.Add(linha);
            }
        }
    }
}
