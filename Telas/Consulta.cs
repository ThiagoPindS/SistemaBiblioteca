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

            AtualiazarAcervo();
        }

        private void btnAlterarStatus_Click(object sender, EventArgs e)
        {
            var Celula = dgvAcervo.CurrentRow.Index;

            Cadastrar.instance.livros.RemoveAt(dgvAcervo.CurrentRow.Index);
        }

        public void AtualiazarAcervo()
        {
            dgvAcervo.DataSource = Cadastrar.instance.livros.ToList();
        }
    }
}
