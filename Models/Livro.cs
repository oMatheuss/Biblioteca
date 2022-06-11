using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Id { get; set; }
        public string Editora { get; set; }
        public int Ano { get; set; }
        public int Quantidade { get; set; }
    }
}
