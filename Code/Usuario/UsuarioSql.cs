using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Models;

namespace Biblioteca.UsuarioDal
{
    class UsuarioSql
    {
        public static string buscaUsuarioSql(int id)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT * FROM USUARIO WHERE ID = " + id);

            return sql.ToString();
        }
        public static string listarUsuariosSql()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("SELECT * FROM USUARIO");

            return sql.ToString();
        }

        public static string adicionarUsuariosSql(Usuario usuario)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("INSERT INTO USUARIO");
            sql.AppendLine($"VALUES('{usuario.Nome}', '{usuario.Telefone}')");

            return sql.ToString();
        }
    }
}
