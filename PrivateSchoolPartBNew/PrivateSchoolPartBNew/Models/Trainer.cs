using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Models
{
    class Trainer
    {
        public static int T_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Trainer(string firstName, string lastName, string subject)
        {
            GenerateTrainerID();
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public static void GenerateTrainerID()
        {
            T_Id++;
        }
        public override string ToString()
        {
            return $" Trainer {{First Name :{FirstName}, Last Name : {LastName}, Subject {Subject}}}";
        }
    }
}
