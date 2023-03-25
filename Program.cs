using System.Runtime.InteropServices;
using System;
using System.Data.SqlClient;

namespace adodotnet{
    class Program{
        static void Main(string[] args){
            string sqlStringConnection = "Data Source = localhost,1433;Initial Catalog=xtlab;User ID=sa;Password=Password123";
            using var connection = new SqlConnection(sqlStringConnection);
            connection.Open();
            Console.WriteLine(connection.State);
             //..truy van
            connection.Close();
        }
    }
}