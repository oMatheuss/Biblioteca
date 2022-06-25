using Biblioteca.Models;
using Biblioteca.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.LivroDal
{
    class LivroDal
    {
        private MySqlConnection con { get; }
        private MySqlCommand command { get; set; }
        public LivroDal()
        {
            con = Uteis.Connection();
            con.OpenAsync().Wait();
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

        public int AdicionarLivro(Livro livro)
        {
            command.CommandText = LivroSql.adicionarLivro(livro);
            command.Connection = con;
            int i = 0;
            try
            {

                i = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.CloseAsync();
            }
            return i;
        }
    }
}
