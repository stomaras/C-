using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using DemoLibraryy;

/*
 * What an abstract class is how to use it 
 * and when it makes sense to create one 
 * We can't instantitate DataAccess Abstract Class.
 * Abstarct class blends both the base class and the interface.
 * 
 */

namespace AbstractClassesRepeat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
                //db.LoadConnectionString("demo");
                //db.LoadData("insert into table");
                //db.SaveData("select * from table");
                Console.WriteLine();
            }
        }
    }
}
