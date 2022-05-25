using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartBProject.Services
{
    class DatabaseInputService
    {
        static string connectionString =
            @"Server = SPYROSTOM\SQLEXPRESS;Database = PrivateSchool; Trusted_Connection = True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public DatabaseInputService()
        {

        }

        public void ConnectToDB()
        {
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();
                    // Insert Student 
                    InsertStudent();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void InsertStudent()
        {
            PrintService.EnterStudentFirstName();
            string firstName = Console.ReadLine();
            PrintService.EnterStudentLastName();
            string lastName = Console.ReadLine();
            PrintService.EnterStudentDateOfBirth();
            PrintService.EnterDayOfBirth();
            int dayOfBirth = Convert.ToInt32(Console.ReadLine());
            PrintService.EnterMonthOfBirth();
            int monthOfBirth = Convert.ToInt32(Console.ReadLine());
            PrintService.EnterYearOfBirth();
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            DateTime dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            PrintService.EnterStudentTuitionFees();
            int tuitionFees = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmdInsert = new SqlCommand($"INSERT INTO Students(FirstName, LastName, DateOfBirth, TuitionFees) VALUES ('{firstName}', '{lastName}', '{dateOfBirth}', '{tuitionFees}')", sqlConnection);
            
            int insertedRows = cmdInsert.ExecuteNonQuery();
            if (insertedRows > 0)
            {
                Console.WriteLine("Success");
            }
            {

            }
        }
    }
}
