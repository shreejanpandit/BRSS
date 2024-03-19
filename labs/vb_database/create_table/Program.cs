//C# program to create table 

using MySql.Data.MySqlClient;
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        MySqlConnection connection = Program.Connection();
        Program.CreateTable(connection);
    }

    static MySqlConnection Connection()
    {
        string cs = $"server='localhost';userid='root';password='';database='vb'";

        MySqlConnection con = new MySqlConnection(cs);

        try
        {
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection has been made successfully");
            }
        }
        catch (MySqlException ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        return con; // Return the MySqlConnection
    }

    static void CreateTable(MySqlConnection connection)
    {
        string createTableQuery = "CREATE TABLE IF NOT EXISTS Person (Id INT AUTO_INCREMENT PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50), Contact VARCHAR(50))";
        MySqlCommand command = new MySqlCommand(createTableQuery, connection);


            command.ExecuteNonQuery();

        System.Console.WriteLine("Table created successfully");
    }
}
