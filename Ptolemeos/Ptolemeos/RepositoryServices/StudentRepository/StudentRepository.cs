using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.RepositoryServices.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            Console.WriteLine("Adding Student to database...");
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Console.WriteLine("Delete Student from database");
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            Console.WriteLine("Getting Student from database");
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            Console.WriteLine("Getting all Students from database");
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            Console.WriteLine("Update Student From Database");
            throw new NotImplementedException();
        }
    }
}
