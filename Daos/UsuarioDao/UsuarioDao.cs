using Biblioteca.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.UsuarioDao
{
    class UsuarioDao
    {
        private MySqlConnection con { get; }
        private MySqlCommand command { get; set; }
        public UsuarioDao()
        {
            con = Uteis.Connection();
            con.Open();
            command = con.CreateCommand();
        }

        public DataSet ListarUsuarios()
        {
            DataSet saida = new();
            try
            {
                var adapter = new MySqlDataAdapter(UsuarioSql.listarUsuariosSql(), con);
                adapter.Fill(saida);
            } catch (Exception)
            {
                throw;
            } finally 
            {
                con.CloseAsync();
            }
            return saida;
        }
    }
}
