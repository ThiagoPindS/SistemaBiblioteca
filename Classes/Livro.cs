using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO_Abril_Ian_Pereira.Classes
{
    public class Livro
    {
        public int? ID { get; set; }

        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public int? AnoPublicacao { get; set; }

        public string? Status { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao, string status)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Titulo};{Autor};{AnoPublicacao};{Status}";
        }
    }
}
