using PARTB.Models.RandomServices;
using PARTB.View.ErrorMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Models.CustomValidations
{
    public class HelperAssigment
    {
        #region Helper Assigment Methods 
        public string CheckTitle(string title)
        {
            bool isTitleValid = false;

            while (!isTitleValid)
            {
                Func<string, bool> ValidAssigmentTitleRange = ValidAssigmentTitle;
                isTitleValid = ValidAssigmentTitleRange.Invoke(title);

                
                
                if (isTitleValid)
                {
                    return title;
                }
                else
                {
                    Func<List<string>> allTitles = AvailableAssigmentTitles;
                    List<string> allAssigmentTitles = allTitles.Invoke();
                    ErrorMessage.WrongAssigmentTitle(allAssigmentTitles);
                    title = Console.ReadLine();
                }
            }
            return title;
        }

        public string CheckDescription(string description)
        {
            bool isDescriptionValid = false;

            while (!isDescriptionValid)
            {
                Func<string, bool> ValidDescription = ValidAssigmentDescripion;
                isDescriptionValid = ValidDescription.Invoke(description);

                if (isDescriptionValid)
                {
                    return description;
                }
                else
                {
                    Func<List<string>> allDescription = AllAvailableDescriptions;
                    List<string> allDescriptions = allDescription.Invoke();
                    ErrorMessage.WrongAssigmentDescription(allDescriptions);
                    description = Console.ReadLine();
                }
            }
            return description;
        }

        public int CheckCourseId(string courseId, List<Course> Courses)
        {
            int numericValue;
            bool isNumber = false;
            bool isValidRange = false;
            int cid = -1;
            while (!isNumber || !isValidRange)
            {
                isNumber = int.TryParse(courseId, out numericValue);

                if (isNumber)
                {
                    cid = numericValue;
                    bool isFound = SearchForCourseId(cid, Courses);
                    if (isFound)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        ErrorMessage.InValidIdToRegister(Courses);
                        isValidRange = false;
                        courseId = Console.ReadLine();
                    }
                }
                else
                {
                    ErrorMessage.CourseIdMustBeNumber();
                    isNumber = false;
                    courseId = Console.ReadLine();
                }
            }
            return cid;
            
        }

        public DateTime CalculateSubDateTime(int courseId, List<Course> courses)
        {
            DateTime subDateTime = new DateTime();
            foreach (var course in courses)
            {
                if (courseId == course.CourseId)
                {
                    DateTime start = course.Start_Date;
                    DateTime end = course.End_Date;
                    subDateTime = InitializeSubmissionDateTime(start, end);
                }
                
            }
            return subDateTime;
        }
        public bool SearchForCourseId(int cid, List<Course> Courses)
        {
            bool isFound = false;
            foreach (var course in Courses)
            {
                if (course.CourseId == cid)
                {
                    isFound = true;
                }
            }
            return isFound;
        }


        public DateTime InitializeSubmissionDateTime(DateTime start, DateTime end)
        {
            int year = start.Year + 1;
            int month = start.Month + 1;// in next bootcamp
            int day = RandomService.Number(1, 30);
            if (month == 2)
            {
                day = RandomService.Number(1, 28);
            }
 
            return new DateTime(year,month,day);
        }
        #endregion

        #region Helper Assigment Methods Which Used With Delegates

        public bool ValidAssigmentTitle(string title)
        {
            if (title.ToLower() == "part a2" || title.ToLower() == "part a3" || title.ToLower() == "part b2" || title.ToLower() == "part b3"
                || title.ToLower() == "part c2" || title.ToLower() == "part c3" || title.ToLower() == "part d2" || title.ToLower() == "part d3"
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidAssigmentDescripion(string description)
        {
            if (description.ToLower() == "front end advanced" || (description.ToLower() == "back end advanced") || (description.ToLower() == "databases advanced") || (description.ToLower() == "design patterns advanced"
                || description.ToLower() == "algorithms" || description.ToLower() ==  "algorithms advanced"
                ))
            
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> AvailableAssigmentTitles()
        {
            List<string> titles = new List<string>();
            titles.Add("Part A2");
            titles.Add("Part A3");
            titles.Add("Part B2");
            titles.Add("Part B3");
            titles.Add("Part C2");
            titles.Add("Part C3");
            titles.Add("Part D2");
            titles.Add("Part D3");

            return titles;
        }

        public List<string> AllAvailableDescriptions()
        {
            List<string> descriptions = new List<string>();
            descriptions.Add("Front End Advanced");
            descriptions.Add("Back End Advanced");
            descriptions.Add("Databases Advanced");
            descriptions.Add("Design Patterns Advanced");
            descriptions.Add("Algorithms");
            descriptions.Add("Algorithms Advanced");

            return descriptions;
        }


        #endregion

    }
}
