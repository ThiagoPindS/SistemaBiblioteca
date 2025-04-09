using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO_Abril_Ian_Pereira.Classes
{
    public class AcervoDeLivros
    {
        static public List<Livro> acervo = new List<Livro>();

        static public List<Livro> livrosFiltrados = new List<Livro>();

        static public void CadastrarLivro(string? titulo, string? autor, string? ano, string? status)
        {
            if (titulo != "" && autor != "" && ano != "" && status != "")
            {
                acervo.Add(new Livro() { ID = acervo.Count, Titulo = titulo, Autor = autor, AnoDaPublicacao = ano, Status = status });

                MessageBox.Show("Livro cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Dados insuficientes para cadastro");
            }
        }

        static public void CarregarAcervo(string origem)
        {
            switch (origem)
            {
                case "todos":
                    {
                        livrosFiltrados = acervo;
                    }
                    break;

                case "filtroPesquisa":
                    {
                        if (Consulta.instance.txtPesquisar != null)
                        {
                            string busca = Consulta.instance.txtPesquisar.Text.ToLower();
                            livrosFiltrados = acervo.Where(l => l.Titulo.ToLower().Contains(busca)).ToList();
                        }
                    }
                    break;

                case "filtroDisponivel":
                    {
                        livrosFiltrados = acervo.Where(l => l.Status.ToLower() == "disponível").ToList();
                    }
                    break;

                case "filtroEmprestado":
                    {
                        livrosFiltrados = acervo.Where(l => l.Status.ToLower() == "emprestado").ToList();
                    }
                    break;
            }

            Consulta.instance.dgvAcervo.DataSource = livrosFiltrados;
        }
    }
}
