using MVCDAY3.Database;
using MVCDAY3.Models;
using MVCDAY3.Repositores.StudentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCDAY3.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        private StudentRepository studentrepository;


        public StudentController()
        {
            studentrepository = new StudentRepository(db);
        }

        // GET: Student
        public ActionResult Index()
        {
            var students = studentrepository.GetStudents();
            return View(students);
        }

        public ActionResult Details(int? id)
        {
            var student = studentrepository.GetStudent(id);
            if (student is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            return View(student);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student stu) // new Student(){...} with all payload features
        {

            if (ModelState.IsValid)
            {
                studentrepository.AddStudent(stu);
                return RedirectToAction("Index");
            }

            return View(stu);
            
        }


        [HttpPost]
        public ActionResult Delete(int? id)
        {
            var student = studentrepository.GetStudent(id);
            if (student == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            studentrepository.DeleteStudent(student);
            TempData["SuccessDeleteStudentMessage"] = $"You have successfully deleted student with name : {student.FirstName} and id {student.StudentId}";
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