using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IndividualPartBProject.Services;

namespace IndividualPartBProject
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Start();
        }
        
        
    }
}
