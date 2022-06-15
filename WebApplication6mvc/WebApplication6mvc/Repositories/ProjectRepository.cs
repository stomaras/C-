using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication6mvc.Data;
using WebApplication6mvc.Models;

namespace WebApplication6mvc.Repositories
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
            var projectsWithEmployees = db.Projects.Include(x => x.Employees).ToList();
            return projectsWithEmployees;
        }

        public Project GetById(int? id)
        {
            var project = db.Projects.Find(id);
            return project;
        }

        public Project GetByIdWithEmployees(int? id)
        {
            var project = GetAllWithEmployees().Find(x=>x.ProjectId == id);
            return project;
        }

        public void Delete(Project project)
        {
            db.Entry(project).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Create(Project project)
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