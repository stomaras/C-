using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Models
{
    class Course
    {
        public static int C_Id { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public Course(string Stream, string Type, DateTime Start_Date, DateTime End_Date)
        {
            GenerateCourseID();
            this.Stream = Stream;
            this.Type = Type;
            this.Start_Date = Start_Date;
            this.End_Date = End_Date;
        }

        public static void GenerateCourseID()
        {
            C_Id++;
        }

        public override string ToString()
        {
            return $"Course {{ Stream {Stream}, Type {Type}, Start_Date {Start_Date}, End_Date {End_Date} }}";
        }
    }
}
