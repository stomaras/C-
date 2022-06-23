using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        ITrainerRepository Trainers { get; }
        ICourseRepository Courses { get; }
        IAssigmentRepository Assigments { get; }

        int complete();

    }
}
