using System;
using System.Collections.Generic;

namespace Hikari_Biblioteca.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public string FotografiaUrl { get; set; }
        public string Biografia { get; set; }
        public string Curiosidades { get; set; } 
        public List<Livro> LivrosRelacionados { get; set; } = new List<Livro>();
    }
}