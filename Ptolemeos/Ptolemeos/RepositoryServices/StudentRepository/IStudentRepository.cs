using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ptolemeos.Entities;
namespace Ptolemeos.RepositoryServices.StudentRepository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student Get(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
        
    }
}
