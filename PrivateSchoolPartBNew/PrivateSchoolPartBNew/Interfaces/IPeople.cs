using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Interfaces
{
    public interface IPeople
    {

        /*
         * These methods will implement common behaviours for classes 
         * Student and Trainer.
         */
        string CheckFirstName(string firstName);
        string CheckLastName(string lastName);
    }
}
