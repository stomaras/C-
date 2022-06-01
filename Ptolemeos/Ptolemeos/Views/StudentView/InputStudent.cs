using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Views.StudentView
{
    public class InputStudent : IInputStudent
    {
        public Student GetDataForEdit()
        {
            Console.WriteLine("Get Student From Console For Edit");
            throw new NotImplementedException();
        }

        public int GetIdForDelete()
        {
            Console.WriteLine("Get Id From Console In Order To Delete");
            throw new NotImplementedException();
        }

        public Student GetStudentData()
        {
            throw new NotImplementedException();
        }
    }
}
