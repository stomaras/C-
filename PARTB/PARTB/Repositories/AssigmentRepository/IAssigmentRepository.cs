using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Repositories.AssigmentRepository
{
    public interface IAssigmentRepository
    {
        List<Assigment> GetAllAssigments();

        void AddAssigment(Assigment assigment);
    }
}
