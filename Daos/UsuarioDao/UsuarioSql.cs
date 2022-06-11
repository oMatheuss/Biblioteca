using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.UsuarioDao
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
    }
}
