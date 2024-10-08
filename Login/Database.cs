using System;
using System.Data.SqlClient;

public class Database
{
    private string connectionString_;
    private string tableName_;
    SqlConnection connection_;

    public Database()
    {
        connectionString_ = @"Data Source=se-database.database.windows.net;Initial Catalog=SQL_jiin;User ID=;Password=";
        tableName_ = "login";
        connection_ = new SqlConnection(connectionString_);
        connection_.Open();
    }

    public bool Query(string username, string password)
    {
        string queryString = "SELECT * FROM " + tableName_ + " WHERE username = @Username AND password = @Password";
        SqlCommand command = new SqlCommand(queryString, connection_);
        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@Password", password);

        SqlDataReader result = command.ExecuteReader();
        if (result.HasRows)
        {
            result.Close();
            return true;
        }
        else
        {
            result.Close();
            return false;
        }
    }

    public bool CheckUsername(string username)
    {
        string queryString = "SELECT COUNT(*) FROM " + tableName_ + " WHERE username = @Username";
        SqlCommand command = new SqlCommand(queryString, connection_);
        command.Parameters.AddWithValue("@Username", username);

        int count = Convert.ToInt32(command.ExecuteScalar());

        return count > 0;
    }


    public void AddUser(string username, string password)
    {
        string insertQuery = "INSERT INTO " + tableName_ + " (username, password) VALUES (@Username, @Password)";
        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection_))
        {
            insertCommand.Parameters.AddWithValue("@Username", username);
            insertCommand.Parameters.AddWithValue("@Password", password);

            insertCommand.ExecuteNonQuery();
        }
    }
}
