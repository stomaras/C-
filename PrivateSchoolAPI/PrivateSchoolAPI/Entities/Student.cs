﻿namespace PrivateSchoolAPI.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
