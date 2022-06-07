using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPartBFinal.GeneralServices;
using SchoolPartBFinal.RepositoryServices.StudentRepository;
using SchoolPartBFinal.Validations;

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

        public static Student CreateStudent(int id, string firstName, string lastName, DateTime dateTime, decimal tuitionFees)
        {
            return new Student(id, firstName,lastName, dateTime, tuitionFees);
        }

        public static List<int> CreateListWithInts()
        {
            return new List<int>();
        }

        public static StudentRepository CreateStudentRepositoryObject()
        {
            return new StudentRepository();
        }

        public static Helper CreateHelper()
        {
            return new Helper();
        }

        public static List<int> StudentIds()
        {
            return new List<int>();
        }
    }
}
