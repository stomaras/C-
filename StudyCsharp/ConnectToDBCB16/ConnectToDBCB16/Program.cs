using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDBCB16
{
    class Program
    {
        // connection to database

        static string connectionString = @"Server = SPYROSTOM\SQLEXPRESS;Database = afdemp_csharp_1; Trusted_Connection = True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        static void Main(string[] args)
        {
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();
                    // Insert User
                    //Console.WriteLine("Enter User Name and Password:");
                    //string username = Console.ReadLine();
                    //string password = Console.ReadLine();

                    //SqlCommand cmdInsert = new SqlCommand($"INSERT INTO users(username, password) VALUES('{username}', '{password}')", sqlConnection);
                    //int insertedRows = cmdInsert.ExecuteNonQuery();
                    //if (insertedRows > 0)
                    //{
                    //    Console.WriteLine("INSERTED Successfull");
                    //    Console.WriteLine($"{insertedRows} rows inserted.");
                    //}

                    // SELECT
                    SqlCommand cmdSelect = 
                        new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @username AND password = @password", sqlConnection);
                    cmdSelect.Parameters.AddWithValue("@username", "tom");
                    cmdSelect.Parameters.AddWithValue("@password", "123");

                    int result = (int)cmdSelect.ExecuteScalar();
                    if (result > 0)
                    {
                        Console.WriteLine("User Found");
                    }
                    else
                    {
                        Console.WriteLine("User Not Found!!!");
                    }

                    // Login
                    Console.WriteLine("Enter username and password to login:");
                    string userNameInserted = Console.ReadLine();
                    string passwordInserted = Console.ReadLine();
                    SqlCommand cmdLogin =
                        new SqlCommand($"SELECT ID, username, password FROM users WHERE username = '{userNameInserted}' AND password = '{passwordInserted}'", sqlConnection);

                    SqlDataReader reader = cmdLogin.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("User Logged in successfully!");
                        User user = new User();
                        user.ID = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Password = reader.GetString(2);

                        Console.WriteLine(user);
                    }
                    // readers must close
                    reader.Close();

                    // select multiple users
                    List<User> users = new List<User>();
                    SqlCommand cmdUsers = new SqlCommand("SELECT ID, username, password FROM users", sqlConnection);
                    SqlDataReader readerUsers = cmdUsers.ExecuteReader();// like a table this object

                    Console.WriteLine("Users:");
                    while (readerUsers.Read())
                    {
                        User user = new User()
                        {
                            ID = readerUsers.GetInt32(0),// Properties Hold data
                            Name = readerUsers.GetString(1),
                            Password = readerUsers.GetString(2)
                        };
                        users.Add(user);// Objects in a List
                    }
                    // reader must close
                    readerUsers.Close();

                    foreach (var user in users)
                    {
                        Console.WriteLine(user);
                    }

                    // update
                    Console.WriteLine("Enter a Username for Update:");
                    string nameForUpdate = Console.ReadLine();
                    Console.WriteLine($"Enter a New Password for the user {nameForUpdate}");
                    string newPassword = Console.ReadLine();

                    SqlCommand cmdUpdate = new SqlCommand($"UPDATE users SET Password = '{newPassword}' WHERE username = '{nameForUpdate}'", sqlConnection);
                    int rowsUpdated = cmdUpdate.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                    {
                        Console.WriteLine("Updated Successfully");
                        Console.WriteLine($"{rowsUpdated} rows updated");
                    }

                    // delete 
                    Console.WriteLine("Enter a user to DELETE:");
                    string nameForDelete = Console.ReadLine();
                    SqlCommand cmdDelete = new SqlCommand($"DELETE FROM users WHERE username = '{nameForDelete}'", sqlConnection);

                    int rowsDeleted = cmdDelete.ExecuteNonQuery();
                    if (rowsDeleted > 0)
                    {
                        Console.WriteLine("Delete Successful");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
