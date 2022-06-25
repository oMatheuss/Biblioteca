using Biblioteca.Helpers;
using Biblioteca.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.UsuarioDal
{
    class UsuarioDal
    {
        private MySqlConnection con { get; }
        private MySqlCommand command { get; set; }
        public UsuarioDal()
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

        public int AdicionarUsuario(Usuario usuario)
        {
            command.CommandText = UsuarioSql.adicionarUsuariosSql(usuario);
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
