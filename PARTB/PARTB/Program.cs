using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARTB.Controllers;
using PARTB.Enums;
using PARTB.Models.CustomValidations;
using PARTB.View.Menu;

namespace PARTB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            School school = new School();
            school.Start();
        }
    }
}

