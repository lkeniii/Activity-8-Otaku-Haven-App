using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace OtakuHavenApp
{
    public static class DBConnection
    {
        private static string connectionString = "server=localhost;uid=root;password=acosta;database=animeotakuhaven;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
