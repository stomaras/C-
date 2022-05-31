using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    /*
     * app.config is useages fot the app
     * 
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            boringDataEntities db = new boringDataEntities();
            // db.Students is a sql query
            // list vs query
            // query is for large scale apps
            var selectAllStudents = db.Students.ToList();

            // IQueryable --> Run in SQL Server
            IQueryable<Student> students = db.Students.Where(x=>x.salary >3000);

            // IEnumerable --> Run in Memory
            IEnumerable<Student> studentss = db.Students.ToList().Where(x => x.salary > 3000);

            Console.WriteLine(students);

            Console.WriteLine(selectAllStudents);

            foreach (var stu in selectAllStudents)
            {
                Console.WriteLine(stu.name);
            }
            Console.WriteLine("---------------------");
            foreach (var stu in selectAllStudents)
            {
                Console.WriteLine(stu.name);
            }


        }
    }
}
