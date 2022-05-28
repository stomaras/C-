using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibraryy
{
    /*
     * You can't create me directly but anything that inherits me get my code
     * We have some code which coming from the base class such as LoadConnectionString
     * " X is a Y"
     */
    public abstract class DataAccess
    {
        // if you want to overrde this method you have to use the keyword virtual
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        /// <summary>
        /// I am not gonna have any code data because 
        /// the data loads gonna look different from sql server to sqlite 
        /// </summary>
        /// <param name="sql"></param>
        public abstract void LoadData(string sql);

        /// <summary>
        ///The data saved different from dql server to sql lite.
        /// </summary>
        /// <param name="sql"></param>
        public abstract void SaveData(string sql);
    }
}
