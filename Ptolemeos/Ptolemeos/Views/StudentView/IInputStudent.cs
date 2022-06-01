using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ptolemeos.Entities;

namespace Ptolemeos.Views.StudentView
{
    public interface IInputStudent
    {
        Student GetStudentData();

        int GetIdForDelete();

        Student GetDataForEdit();


    }
}
