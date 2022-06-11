using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    class LivroUsuario
    {
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime dataEmprestimo { get; set; }
    }
}
