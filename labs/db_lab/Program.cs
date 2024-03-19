//program to connect C# with database

namespace db_lab;
using MySql.Data.MySqlClient;
using System.Data;
class Program
{
    static void Main(string[] args)
    {
        Program.Connection();
        CreateTable(connection);

    }

    static void Connection()
    {
        string cs = $"server='localhost';userid='root';password='';database='vb'";

        MySqlConnection con = new MySqlConnection(cs);

        try
        {
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection has been made sucessfully");
            }
        }
        catch (MySqlException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }

    }

    static void CreateTable(MySqlConnection connection)
    {
        string createTableQuery = "CREATE TABLE IF NOT EXISTS person (Id INT AUTO_INCREMENT PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50), Contact VARCHAR(50))";
        using (MySqlCommand command = new MySqlCommand(createTableQuery, connection))
        {
            command.ExecuteNonQuery();
        }
    }
}
