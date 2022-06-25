using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.LivroUsuarioDal
{
    class LivroUsuarioSql
    {
        public static string emprestimos()
        {
            StringBuilder sql = new();

            sql.AppendLine("select a.Nome, b.Titulo, c.DataEmprestimo");
            sql.AppendLine("from livrousuario C");
            sql.AppendLine("Inner join usuario A on c.Id_Usuario = A.Id");
            sql.AppendLine("Inner join livro B on c.Id_Livro = b.Id");

            return sql.ToString();
        }

        public static string fazerEmprestimo()
        {
            StringBuilder sql = new();

            return sql.ToString();
        }
    }
}
