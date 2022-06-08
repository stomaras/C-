using MVCDay2Begin.Data;
using MVCDay2Begin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDay2Begin.Repositories.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {

        ApplicationContext db;

        public StudentRepository(ApplicationContext context)
        {
            db = context;
        }

        public void DeleteStudent(Student student)
        {
            db.Entry(student).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public Student GetStudent(int? id)
        {
            var student = db.Students.Find(id);
            return student;
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }


    }
}