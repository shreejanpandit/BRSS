//program to connect C# with database

namespace db_lab;
using MySql.Data.MySqlClient;
using System.Data;
class Program
{
    static void Main(string[] args)
    {
        Program.Connection();

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
}
