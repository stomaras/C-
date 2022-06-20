using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;
using WebApplication8.MyDatabase;
using WebApplication8.Repositories;

namespace WebApplication8.Controllers
{
    public class ProjectController : Controller
    {
        private ApplicationContext db = new ApplicationContext();

        private ProjectRepository projectRepository;
        private EmployeeRepository employeeRepository;

        public ProjectController()
        {
            projectRepository = new ProjectRepository(db);
            employeeRepository = new EmployeeRepository(db);
        }

        // GET: Project
        public ActionResult Index()
        {
            var projects = projectRepository.GetAllWithEmployees();
            return View(projects);
        }

        // GET: Project/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = projectRepository.GetByIdWithProjects(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            GetEmployees();
            return View(project);
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title")] Project project)
        {
            if (ModelState.IsValid)
            {
                projectRepository.Add(project);
               
                return RedirectToAction("Index");
            }

            return View(project);
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = projectRepository.GetById(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title")] Project project)
        {
            if (ModelState.IsValid)
            {
                projectRepository.Add(project);
                return RedirectToAction("Index");
            }
            return View(project);
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = projectRepository.GetByIdWithProjects(id);    
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = projectRepository.GetById(id);
            projectRepository.Delete(project);
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

        [NonAction]
        public void GetEmployees()
        {
            List<Employee> employees = employeeRepository.GetAll();
            ViewBag.Employees = employees;
        }
    }
}
