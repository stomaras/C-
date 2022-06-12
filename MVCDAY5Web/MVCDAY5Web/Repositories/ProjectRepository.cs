using MVCDAY5Web.Data;
using MVCDAY5Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDAY5Web.Repositories
{
    public class ProjectRepository
    {

        private ApplicationContext db;

        public ProjectRepository(ApplicationContext context)
        {
            db = context;
        }

        public List<Project> GetAll()
        {
            var projects = db.Projects.ToList();
            return projects;
        }

        public List<Project> GetAllWithEmployees()
        {
            var ProjectWithEmployees = db.Projects.SqlQuery("SELECT * FROM Projects INNER JOIN Employees ON Projects.Id = Employees.ProjectId").ToList();
            return db.Projects.Include(x => x.Employees).ToList();
        }

        public Project GetById(int? id)
        {
            var project = db.Projects.Find(id);
            return project;
        }

        public void Delete(Project project)
        {
            db.Entry(project).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Add(Project project)
        {
            db.Entry(project).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Project project)
        {
            db.Entry(project).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}