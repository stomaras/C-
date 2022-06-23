using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Models.CustomValidations
{
    public  class HelperCourse
    {

        public bool ProcessInsertion(string Type, string Title, List<Course> courses)
        {
            bool InsertCondition = false;
            foreach (var course in courses)
            {
                if (Type == course.Type)
                {
                    if (Title == course.Title)
                    {
                        InsertCondition = false;
                        
                    }
                    else
                    {
                        InsertCondition = true;
                    }
                }
                else
                {
                    InsertCondition = true;
                }
            }
            return InsertCondition;
        }
    }
}
