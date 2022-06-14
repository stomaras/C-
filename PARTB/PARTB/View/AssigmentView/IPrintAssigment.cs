using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.AssigmentView
{
    public interface IPrintAssigment
    {
        void PrintAssigments(List<Assigment> students);
    }
}
