using MySql.Data.MySqlClient;
using System;
using System.Data;

class DisconnectedDataSetExample
{
    static void Main()
    {
        string connectionString = "server=localhost;userid=root;password=;database=vb";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Connected to the database");

                // Create a table if not exists
                CreateTable(connection);

                // Disconnected DataSet example
                DataSet dataSet = new DataSet();

                // Fill DataSet with data from the database
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM person", connection))
                {
                    adapter.Fill(dataSet, "Person");
                }

                // Close the connection explicitly after filling the DataSet
                connection.Close();
                Console.WriteLine("Connection closed. now we are not connected to database anymore..");

                // Manipulate data in the DataSet
                // DisplayData(dataSet);

                // CRUD operations in the DataSet
                InsertData(dataSet, "john", "doe");
                // UpdateData(dataSet, 1, "jonny", "doe");
                // DeleteData(dataSet, 2);

                // Display modified data in the DataSet
                // Console.WriteLine("\nData after CRUD operations:");
                // DisplayData(dataSet);

                // Reopen the connection
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connected to the database again for reflecting changes back");

                    // Use DataAdapter to reflect changes back to the database
                    using (MySqlDataAdapter updateAdapter = new MySqlDataAdapter("SELECT * FROM person", connection))
                    {
                        MySqlCommandBuilder builder = new MySqlCommandBuilder(updateAdapter);

                        // Update the changes in the DataSet to the database
                        updateAdapter.Update(dataSet, "Person");
                    }

                    // Display data from the database after updates
                    // Console.WriteLine("\nData in the database after updates:");
                    // DisplayDataFromDatabase(connection);
                }
            }
        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // Ensure the connection is closed even if an exception occurs
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

    static void CreateTable(MySqlConnection connection)
    {
        string createTableQuery = "CREATE TABLE IF NOT EXISTS person (Id INT AUTO_INCREMENT PRIMARY KEY, FirstName VARCHAR(50), LastName VARCHAR(50))";
        using (MySqlCommand command = new MySqlCommand(createTableQuery, connection))
        {
            command.ExecuteNonQuery();
        }
    }

    static void DisplayData(DataSet dataSet)
    {
        Console.WriteLine("\nData in the DataSet:");
        foreach (DataRow row in dataSet.Tables["Person"].Rows)
        {
            Console.WriteLine($"Id: {row["Id"]}, FirstName: {row["FirstName"]}, LastName: {row["LastName"]}");
        }
    }

    static void DisplayDataFromDatabase(MySqlConnection connection)
    {
        Console.WriteLine("\nData in the database:");
        using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM person", connection))
        {
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Person");
            DisplayData(dataSet);
        }
    }

    static void InsertData(DataSet dataSet, string firstName, string lastName)
    {
        DataRow newRow = dataSet.Tables["Person"].NewRow();
        newRow["FirstName"] = firstName;
        newRow["LastName"] = lastName;
        dataSet.Tables["Person"].Rows.Add(newRow);
        Console.WriteLine($"Inserted new data: {firstName} {lastName}");
    }

    static void UpdateData(DataSet dataSet, int id, string newFirstName, string newLastName)
    {
        DataRow[] rows = dataSet.Tables["Person"].Select($"Id = {id}");
        if (rows.Length > 0)
        {
            DataRow row = rows[0];
            row["FirstName"] = newFirstName;
            row["LastName"] = newLastName;
            Console.WriteLine($"Updated data for Id {id}: {newFirstName} {newLastName}");
        }
        else
        {
            Console.WriteLine($"No data found for Id {id}");
        }
    }

    static void DeleteData(DataSet dataSet, int id)
    {
        DataRow[] rows = dataSet.Tables["Person"].Select($"Id = {id}");
        if (rows.Length > 0)
        {
            rows[0].Delete();
            Console.WriteLine($"Deleted data for Id {id}");
        }
        else
        {
            Console.WriteLine($"No data found for Id {id}");
        }
    }
}
