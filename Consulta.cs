using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_POO_Abril_Ian_Pereira
{
    public partial class Consulta : Form
    {
        public Cadastrar rodolfo { get; set; }
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            rodolfo.ShowDialog();
            //this.Show();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            rodolfo = new Cadastrar();
        }
    }
}
