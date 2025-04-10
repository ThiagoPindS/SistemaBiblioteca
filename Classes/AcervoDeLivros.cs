using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO_Abril_Ian_Pereira.Classes
{
    public class AcervoDeLivros
    {
        static public List<Livro> acervo = new List<Livro>();

        static public List<Livro> livrosFiltrados = new List<Livro>();

        public static void CadastrarLivro(string titulo, string autor, int anoPublicacao, string status)
        {
            if (titulo != "" && autor != "" && anoPublicacao != 0 && status != "")
            {
                acervo.Add(new Livro(titulo, autor, anoPublicacao, status));

                SalvarAcervo();

                MessageBox.Show("Livro cadastrado com sucesso", "Êxito", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Dados insuficientes para cadastro", "Erro", MessageBoxButtons.OK);
            }
        }

        public static void ExcluirLivro(int index)
        {
            acervo.RemoveAt(index);

            SalvarAcervo();

            CarregarAcervo();

            ExibirAcervo("Todos");
        }

        public static void EditarAcervo(string titulo, string autor, int ano)
        {
            Consulta.instance.dgvAcervo.CurrentRow.Cells[0].Value = titulo;
            Consulta.instance.dgvAcervo.CurrentRow.Cells[1].Value = autor;
            Consulta.instance.dgvAcervo.CurrentRow.Cells[2].Value = ano;

            SalvarAcervo();
        }

        public static void ExibirAcervo(string origem)
        {
            switch (origem)
            {
                case "Todos":
                    {
                        livrosFiltrados = acervo;
                    }
                    break;

                case "FiltroPesquisa":
                    {
                        if (Consulta.instance.txtPesquisar != null)
                        {
                            string busca = Consulta.instance.txtPesquisar.Text.ToLower().Trim();
                            livrosFiltrados = acervo.Where(l => l.Titulo.ToLower().Trim().Contains(busca)).ToList();
                        }
                    }
                    break;

                case "Disponível":
                    {
                        livrosFiltrados = acervo.Where(l => l.Status.ToLower() == "disponível").ToList();
                    }
                    break;

                case "Emprestado":
                    {
                        livrosFiltrados = acervo.Where(l => l.Status.ToLower() == "emprestado").ToList();
                    }
                    break;
            }

            Consulta.instance.dgvAcervo.DataSource = null;

            Consulta.instance.dgvAcervo.DataSource = livrosFiltrados;
        }

        public static void SalvarAcervo()
        {
            using (StreamWriter writer = new StreamWriter("Acervo.txt"))
            {
                foreach (var livro in acervo)
                {
                    writer.WriteLine(livro.ToString());
                }
            }
        }

        public static void CarregarAcervo()
        {
            acervo.Clear();

            using (StreamReader reader = new StreamReader("Acervo.txt"))
            {
                string linha;

                while ((linha = reader.ReadLine()) != null)
                {
                    var partes = linha.Split(';');

                    if (partes.Length == 4)
                    {
                        var livro = new Livro(partes[0], partes[1], int.Parse(partes[2]), partes[3]);

                        acervo.Add(livro);
                    }
                }
            }
        }

        public static void AlterarStatus()
        {
            if (Consulta.instance.dgvAcervo.CurrentRow.Cells[3].Value.ToString() == "Disponível")
            {
                Consulta.instance.dgvAcervo.CurrentRow.Cells[3].Value = "Emprestado";
            }
            else
            {
                Consulta.instance.dgvAcervo.CurrentRow.Cells[3].Value = "Disponível";
            }

            SalvarAcervo();

            CarregarAcervo();
        }
    }
}
    