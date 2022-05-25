using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Services
{
    class DatabaseService
    {
        static string connectionString =
            @"Server = SPYROSTOM\SQLEXPRESS;Database = PrivateSchool; Trusted_Connection = True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public DatabaseService()
        {

        }
        /// <summary>
        /// This method open connection with Database Private School
        /// </summary>
        public void ConnectToDB()
        {
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        /// <summary>
        /// This method close connection with Database Private School
        /// </summary>
        public void CloseDB()
        {
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Close();
                    // Insert Student 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="subject"></param>
        public static void InsertTrainer(string firstName, string lastName, string subject)
        {
            string query = "INSERT INTO Trainers(firstName, lastName, subject) VALUES('" + firstName + "','" + lastName + "','" + subject + "');";
            sqlConnection.Open();
            SqlCommand cmdInsertTrainer = new SqlCommand(query,sqlConnection);
            cmdInsertTrainer.ExecuteNonQuery();
            sqlConnection.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateTime"></param>
        /// <param name="tuitionFees"></param>
        public static void InsertStudent(string firstName, string lastName, DateTime dateTime, int tuitionFees)
        {
            string query = "INSERT INTO Students(firstName, lastName, dateTime, tuitionFees) VALUES('" + firstName + "','" + lastName + "','" + dateTime + "','" + tuitionFees + "');";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        /// <summary>
        ///  Return All Trainers Of PrivateSchool
        /// </summary>
        /// <returns></returns>
        public static string SelectTrainers()
        {
            string result = "";
            string selectQuery = "SELECT * FROM Trainers;";
            sqlConnection.Open();
            using (SqlCommand cmd = new SqlCommand(selectQuery,sqlConnection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result += reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + "\n";
                    }
                }
            }
            sqlConnection.Close();
            return result;
        }

    }
}
