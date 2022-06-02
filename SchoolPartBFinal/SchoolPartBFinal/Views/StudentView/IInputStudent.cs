using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Views.StudentView
{
    public interface IInputStudent
    {
        Student EnterStudentToCreate();
        int EnterStudentIdToDelete();
        Student EnterStudentDetailsToUpdate();

    }
}
