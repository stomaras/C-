using Entities;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Areas.Admin.Controllers.APIControllers
{
    public class StudentAPIController : Controller
    {
        MyDatabase.ApplicationDbContext db = new MyDatabase.ApplicationDbContext();
        UnitOfWork unit;

        public StudentAPIController()
        {
            unit = new UnitOfWork(db);
        }

        [HttpGet]
        public ActionResult GetNames()
        {
            var names = unit.Students.GetAll().Select(x=> new { x.Name});

            return Json(names,JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetStudents()
        {
            var students = unit.Students.GetAll();
            return Json(students, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                unit.Students.Insert(student);
                unit.Complete();
                return Json(student, JsonRequestBehavior.AllowGet);
                // All create HTTPOST
                // return new HttpStatusCodeResult(HttpStatusCode.Created) or HttpStatusCode.Ok
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
        }

        [HttpPost]
        public ActionResult CreateStudentWithRandomScore(string name)
        {
            Random random = new Random();
            var score = random.Next(1, 101);

            Student student = new Student()
            {
                Name = name,
                Score = score
            };

            if (ModelState.IsValid)
            {
                unit.Students.Insert(student);
                unit.Complete();
                return Json(student, JsonRequestBehavior.AllowGet);
                // All create HTTPOST
                // return new HttpStatusCodeResult(HttpStatusCode.Created) or HttpStatusCode.Ok
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

        }

        // AJAX CALLS -- Many Methods 
        // In Forms -- Only POST AND GET
        [HttpDelete]
        public ActionResult DeleteStudentById(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var student = unit.Students.GetById(id);

            if (student == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            unit.Students.Delete(id);
            unit.Complete();

            return Json(student, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public ActionResult DeleteAllStudents()
        {
            unit.Students.DeleteAll();
            unit.Complete();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpDelete]
        public ActionResult DeleteAllAboveScore(int? score)
        {
            if (score == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            unit.Students.DeleteBy(x => x.Score > score);
            unit.Complete();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPut]
        public ActionResult EditStudent(int? id, Student student)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var stu = unit.Students.GetById(id);
            if (stu == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            // Mapping
            stu.Name = student.Name;
            stu.Score = student.Score;

            unit.Students.Update(stu);
            unit.Complete();
            return Json(stu, JsonRequestBehavior.AllowGet);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unit.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}