using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Daos.LivroDao
{
    class LivroSql
    {
        public static string buscaLivroSql(int id)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT * FROM LIVRO WHERE ID = " + id);

            return sql.ToString();
        }

        public static string buscaLivroPorTituloSql(string titulo)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT * FROM LIVRO WHERE TITULO = " + titulo);

            return sql.ToString();
        }

        public static string listarLivrosSql()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT * FROM LIVRO");

            return sql.ToString();
        }

        public static string adicionarLivro(Livro livro) {
            StringBuilder sql = new StringBuilder();
            
            sql.AppendLine("INSERT INTO LIVRO");
            sql.AppendLine($"VALUES({livro.Titulo}, {livro.Autor}, {livro.Id}, {livro.Editora}, {livro.Ano}, {livro.Quantidade})");

            return sql.ToString();
        }
    }
}
