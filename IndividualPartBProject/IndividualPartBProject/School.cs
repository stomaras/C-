using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualPartBProject.Models;
using IndividualPartBProject.Services;

namespace IndividualPartBProject
{
    class School
    {
        public int NumOfAssigments { get; set; }
        public int NumOfCourses { get; set; }
        public int NumOfStudents { get; set; }
        public int NumOfTrainers { get; set; }

        
        public School() { }

        public void Start()
        {
            DatabaseInputService databaseInputService = new DatabaseInputService();
            databaseInputService.ConnectToDB();
            
        }
    }
}
