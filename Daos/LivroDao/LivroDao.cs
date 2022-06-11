using Biblioteca.Daos.LivroDao;
using Biblioteca.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.LivroDao
{
    class LivroDao
    {
        private MySqlConnection con { get; }
        private MySqlCommand command { get; set; }
        public LivroDao()
        {
            con = Uteis.Connection();
            con.Open();
            command = con.CreateCommand();
        }

        public DataSet ListarLivros()
        {
            DataSet saida = new();
            command.CommandText = LivroSql.listarLivrosSql();
            try
            {
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(saida);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseAsync();
            }
            return saida;
        }
    }
}
