using BubbleSort2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BubbleSort2.Student;

namespace BubbleSort2
{
    public static class BubbleSort
    {
        /*
         * We create our own extended method.
         * 
         * 1) Add this keyword in parameter variables.
         * 2) static keyword in class.
         * 
         * 
         */

        
        public static void OrderBy(this List<Student> students)
        {
            Student temp;
            for (int i = 0; i <= students.Count - 2; i++)
            {
                for (int j = 0; j <= students.Count - 2; j++)
                {
                    if (students[i].Score < students[i + 1].Score)
                    {
                        temp = students[i + 1];
                        students[i + 1] = students[i];
                        students[i] = temp;
                    }
                }
            }
            
        }
    }
}
