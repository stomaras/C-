using Ptolemeos.Entities;
using Ptolemeos.MyDatabase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.RepositoryServices.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(student).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var student = db.Students.Find(id);
                if (student != null)
                {
                    db.Entry(student).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Student with {id} dos not exist's");
                }
            }
        }

        public Student Get(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var student = db.Students.Find(id);
                return student;
            }
        }

        public List<Student> GetAll()
        {
            // with using or dispose
            using (ApplicationContext db = new ApplicationContext() )
            {
                return db.Students.ToList();
            }
        }

        public void Update(Student student)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var stu = db.Students.Find(student.Id);

                if (stu != null)
                {
                    stu.Name = student.Name;
                    stu.Score = student.Score;
                    db.Entry(stu).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception($"Student with {student.Id} does not exists!");
                }
            }
        }
    }
}
