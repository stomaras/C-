using MVCDay2Begin.Data;
using MVCDay2Begin.Models;
using MVCDay2Begin.Repositories.StudentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCDay2Begin.Controllers
{
    public class StudentController : Controller
    {

        private ApplicationContext db = new ApplicationContext();

        private StudentRepository studentRepository;

        public StudentController()
        {
            studentRepository = new StudentRepository(db);
        }
        // GET: Student
        public ActionResult Index()
        {
            var students = studentRepository.GetStudents();
            return View(students);
        }

        public ActionResult Details(int? id)
        {
            Student student = studentRepository.GetStudent(id);
            return View(student);
        }

        
        public ActionResult Delete(int? id)
        {
            var student = studentRepository.GetStudent(id);
            if (student == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            studentRepository.DeleteStudent(student);

            TempData["message"] = $"You have succesully deleted student with first name {student.FirstName} , with last name {student.LastName}";
            
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}