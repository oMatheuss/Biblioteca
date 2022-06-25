using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca.Helpers
{
    class Uteis
    {
        public static string ConnectionString()
        {
            return "server=127.0.0.1;user=root;password=uniube22;database=biblioteca";
        }

        public static MySqlConnection Connection()
        {
            try
            {
                return new MySqlConnection(ConnectionString());
                //return new MySqlConnection(ConnectionString());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
