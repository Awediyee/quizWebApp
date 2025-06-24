using System;
using Microsoft.Data.SqlClient;

namespace quizSystem
{
    public class dbConnection
    {
        private SqlConnection connect;
        private string connectStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\AWEDI\\source\\repos\\quizSystem\\quizSystem\\quizDatabase.mdf;Integrated Security=True";

        public dbConnection()
        {
            connect = new SqlConnection(connectStr);
        }

        public SqlConnection GetConnection()
        {
            try
            {
                // Create a new SqlConnection instance for each call
                SqlConnection connect = new SqlConnection(connectStr);
                connect.Open(); // Open the connection
                return connect;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
                return null;
            }
        }

        public void CloseConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}