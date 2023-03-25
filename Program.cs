using System.Runtime.InteropServices;
using System;
using System.Data.SqlClient;

namespace adodotnet{
    class Program{
        static void Main(string[] args){
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder["Server"] = "localhost, 1433";
            sqlStringBuilder["Database"] = "xtlab";
            sqlStringBuilder["UID"] = "sa";
            sqlStringBuilder["PWD"] = "Password123";

            var sqlStringConnection = sqlStringBuilder.ToString();
            Console.WriteLine(sqlStringConnection);
            // string sqlStringConnection = "Data Source = localhost,1433;Initial Catalog=xtlab;User ID=sa;Password=Password123";
            using var connection = new SqlConnection(sqlStringConnection);
            connection.Open();
            Console.WriteLine(connection.State);
             //..truy van
            connection.Close();
        }
    }
}