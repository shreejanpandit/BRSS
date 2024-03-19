//C# program to fetch data

using MySql.Data.MySqlClient;
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        MySqlConnection connection = Program.Connection();
        Program.FetchData(connection);
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

    static void FetchData(MySqlConnection connection)
    {
        MySqlDataReader reader = null;

        // Connected DataReader example
        MySqlCommand command = new MySqlCommand("SELECT * FROM person where LastName='Doe'", connection);
        reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader["Id"]}, FirstName: {reader["FirstName"]}, LastName: {reader["LastName"]}");
        }

        connection.Close();
    }
}
