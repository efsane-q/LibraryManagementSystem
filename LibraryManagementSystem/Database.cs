
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public static class Database
    {
        public static string ConnectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
