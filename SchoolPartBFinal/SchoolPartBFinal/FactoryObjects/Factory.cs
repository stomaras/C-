using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPartBFinal.GeneralServices;

namespace SchoolPartBFinal.FactoryObjects
{
    public static class Factory
    {

        public static Student CreateStudent()
        {
            return new Student();
        }

        public static List<Student> CreateStudentsList()
        {
            return new List<Student>();
        }

        public static StringEvaluations StringEvaluation()
        {
            return new StringEvaluations();
        }

        public static Student CreateStudent(int id, string firstName, string lastName)
        {
            return new Student(id, firstName,lastName);
        }
    }
}
