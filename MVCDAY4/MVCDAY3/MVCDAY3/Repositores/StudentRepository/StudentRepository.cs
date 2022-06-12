using MVCDAY3.Database;
using MVCDAY3.Models;
using MVCDAY3.Repositores.StudentRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDAY3.Repositores.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationContext db;

        public StudentRepository(ApplicationContext context)
        {
            db = context;
        }

        public void AddStudent(Student student)
        {
            db.Entry(student).State = EntityState.Added;
            db.SaveChanges();
        }

        public void DeleteStudent(Student student)
        {
             db.Entry(student).State = EntityState.Deleted;
             db.SaveChanges();
        }
            

        public Student GetStudent(int? id)
        {
            var student = db.Students.Find(id);
            if (student == null)
            {
                return null;
            } 
            return student;
        }

        public List<Student> GetStudents()
        {
            var students = db.Students.SqlQuery("SELECT * FROM Students").ToList<Student>();
            return students;
        }
    }
}