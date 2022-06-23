using PARTB.Models.CustomValidations;
using PARTB.View.ErrorMessages;
using PARTB.View.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.ObjectFactory
{
    public static class Factory
    {
        public static PrintStudent CreatePrintStudent()
        {
            return new PrintStudent();
        }

        public static Helper CreateHelperObject()
        {
            return new Helper();
        }

        public static HelperCourse CreateHelperCourseObject()
        {
            return new HelperCourse();
        }

        public static HelperAssigment CreateHelperAssigmentObject()
        {
            return new HelperAssigment();
        }
    }
}
