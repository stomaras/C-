using MyDatabase;
using Repositories.Core;
using Repositories.Core.Repositories;
using Repositories.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            context = dbContext;
            Students = new StudentRepository(context);
            Trainers = new TrainerRepository(context);
            Courses = new CourseRepository(context);
            Assigments = new AssigmentRepository(context);
        }
        public IStudentRepository Students { get; private set; }

        public ITrainerRepository Trainers { get; private set; }

        public ICourseRepository Courses { get; private set; }

        public IAssigmentRepository Assigments { get; private set; }

        public int complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
