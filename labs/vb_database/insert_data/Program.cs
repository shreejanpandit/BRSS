using MySql.Data.MySqlClient;
using System;
using System.Data;
class Program
{
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

    static void InsertData(DataSet dataSet, string firstName, string lastName, string contact)
    {
        DataRow addRow = dataSet.Tables["PersonDs"].NewRow();
        addRow["FirstName"] = firstName;
        addRow["LastName"] = lastName;
        addRow["Contact"] = contact;
        dataSet.Tables["PersonDs"].Rows.Add(addRow);
        Console.WriteLine($"Inserted new data: {firstName} {lastName}, Contact: {contact} into dataset");
    }
    static void Main(string[] args)
    {
        MySqlConnection connection = Program.Connection();
        DataSet dataSet = new DataSet();

        // Fill DataSet with data from the database
        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM person", connection);
        adapter.Fill(dataSet, "PersonDs");

        // Close the connection explicitly after filling the DataSet
        connection.Close();
        Console.WriteLine("Connection closed. Now we are not connected to the database anymore.");

        // CRUD operations in the DataSet
        InsertData(dataSet, "Perter", "Parker", "perterparker@example.com");
        InsertData(dataSet, "John2", "Doe", "john.doe@example.com");

        // System.Console.WriteLine("");
        // foreach (DataRow row in dataSet.Tables["PersonDs"].Rows)
        // {
        //     Console.WriteLine($"I am in dataset :FirstName: {row["FirstName"]}, LastName: {row["LastName"]}, Contact: {row["Contact"]}");
        // }

        // Reopen the connection
        connection.Open();

        if (connection.State == ConnectionState.Open)
        {
            Console.WriteLine("Connected to the database again for reflecting changes back to database");

            // Use DataAdapter to reflect changes back to the database
            MySqlDataAdapter updateAdapter = new MySqlDataAdapter("SELECT * FROM person", connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(updateAdapter);

            // Update the changes in the DataSet to the database
            updateAdapter.Update(dataSet, "PersonDs");
        }


    }

  
}
