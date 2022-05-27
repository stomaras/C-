using PrivateSchoolRepeatPartA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolRepeatPartA.Services;

namespace PrivateSchoolRepeatPartA
{
    class Database
    {

        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assigment> Assigments { get; set; } = new List<Assigment>();
        public int NumOfStudents { get; set; }
        public int NumOfTrainers { get; set; }
        


        public Database()
        {
            NumOfStudents = RandomService.Number(10, 20);
            NumOfTrainers = RandomService.Number(5, 10);
            

            #region Seeding Students
            for (int i = 0; i <= NumOfStudents-1; i++)
            {
                Student student = new Student()
                {
                    //to do Generate a unique id for the student
                    Student_Id = RandomService.Number(1, 3000000),
                    FirstName = RandomService.RandFirstName(),
                    LastName = RandomService.RandLastName(),
                    BirthDate = new DateTime(RandomService.Number(1960, DateTime.Now.Year - 18), RandomService.Number(1, 12), RandomService.Number(1, 30)),
                    TuitionFees = 2500
                };
                Students.Add(student);
            }


            #endregion

            #region Seeding Trainers
            for (int i = 0; i <= NumOfTrainers-1; i++)
            {
                Trainer trainer = new Trainer()
                {
                    Trainer_Id = RandomService.Number(1, 300000),
                    FirstName = RandomService.RandTrainerFirstName(),
                    LastName = RandomService.RandTrainerLastName(),
                    Subject = RandomService.Subject()
                };
                Trainers.Add(trainer);
            }

            //Trainer trainer1 = new Trainer()
            //{
            //    Trainer_Id = 1,
            //    FirstName = "Linus",
            //    LastName = "Torvalds",
            //    Subject = "c#"
            //};

            //Trainer trainer2 = new Trainer()
            //{
            //    Trainer_Id = 2,
            //    FirstName = "Mark",
            //    LastName = "Zuckerberg",
            //    Subject = "java"
            //};

            //Trainer trainer3 = new Trainer()
            //{
            //    Trainer_Id = 3,
            //    FirstName = "Bill",
            //    LastName = "Gates",
            //    Subject = "python"
            //};

            //Trainer trainer4 = new Trainer()
            //{
            //    Trainer_Id = 4,
            //    FirstName = "Ektoras",
            //    LastName = "Gkastsos",
            //    Subject = "c#"
            //};
            //Trainer trainer5 = new Trainer()
            //{
            //    Trainer_Id = 1,
            //    FirstName = "Nick",
            //    LastName = "The Quick",
            //    Subject = "c#"
            //};
            //Trainer trainer6 = new Trainer()
            //{
            //    Trainer_Id = 6,
            //    FirstName = "George",
            //    LastName = "Andri",
            //    Subject = "java"
            //};
            //Trainer trainer7 = new Trainer()
            //{
            //    Trainer_Id = 7,
            //    FirstName = "Nikos",
            //    LastName = "Noulas",
            //    Subject = "python"
            //};
            //Trainer trainer8 = new Trainer()
            //{
            //    Trainer_Id = 8,
            //    FirstName = "Milo",
            //    LastName = "Arnaou",
            //    Subject = "javascript"
            //};




            #endregion

            #region Seeding Courses
            //==============================================Seeding Courses ==================================================
            Course course1 = new Course()
            {
                Course_Id = 1,
                Stream = "CB16",
                Type = "Full Time Java",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 05, 28)
            };
            Courses.Add(course1);
            
            

            Course course2 = new Course()
            {
                Course_Id = 2,
                Stream = "CB16",
                Type = "Part Time Java",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 09, 28)
            };
            Courses.Add(course2);

            Course course3 = new Course()
            {
                Course_Id = 3,
                Stream = "CB17",
                Type = "Full Time C#",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 05, 28)
            };
            Courses.Add(course3);

            Course course4 = new Course()
            {
                Course_Id = 4,
                Stream = "CB17",
                Type = "Part Time C#",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 09, 28)
            };
            Courses.Add(course4);

            Course course5 = new Course()
            {
                Course_Id = 5,
                Stream = "CB18",
                Type = "Full Time Python",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 05, 28)
            };
            Courses.Add(course5);

            Course course6 = new Course()
            {
                Course_Id = 6,
                Stream = "CB18",
                Type = "Part Time Python",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 05, 28)
            };
            Courses.Add(course6);

            Course course7 = new Course()
            {
                Course_Id = 7,
                Stream = "CB19",
                Type = "Full Time Javascript",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 05, 28)
            };
            Courses.Add(course7);

            Course course8 = new Course()
            {
                Course_Id = 8,
                Stream = "CB19",
                Type = "Part Time Javascript",
                Start_Date = new DateTime(2022, 02, 28),
                End_Date = new DateTime(2022, 09, 28)
            };
            Courses.Add(course8);









            #endregion

            #region Seeding Assigments

            Assigment assigment1 = new Assigment()
            {
                Assigment_Id = 1,
                Description = "Individual Part A",
                SubmissionDateTime = new DateTime(2022, 02, 03),

            };
            Assigments.Add(assigment1);

            Assigment assigment2 = new Assigment()
            {
                Assigment_Id = 2,
                Description = "Individual Part B",
                SubmissionDateTime = new DateTime(2022, 03, 03),

            };
            Assigments.Add(assigment2);

            Assigment assigment3 = new Assigment()
            {
                Assigment_Id = 3,
                Description = "Assigment 3",
                SubmissionDateTime = new DateTime(2022, 04, 03),

            };
            Assigments.Add(assigment3);

            Assigment assigment4 = new Assigment()
            {
                Assigment_Id = 4,
                Description = "Assigment 4",
                SubmissionDateTime = new DateTime(2022, 05, 03),

            };
            Assigments.Add(assigment4);

            Assigment assigment5 = new Assigment()
            {
                Assigment_Id = 5,
                Description = "IAssigment 5",
                SubmissionDateTime = new DateTime(2022, 06, 03),

            };
            Assigments.Add(assigment5);

            Assigment assigment6 = new Assigment()
            {
                Assigment_Id = 6,
                Description = "Assigment 6",
                SubmissionDateTime = new DateTime(2022, 07, 03),

            };
            Assigments.Add(assigment6);
            Assigment assigment7 = new Assigment()
            {
                Assigment_Id = 7,
                Description = "Assigment 7",
                SubmissionDateTime = new DateTime(2022, 08, 03),

            };
            Assigments.Add(assigment7);

            Assigment assigment8 = new Assigment()
            {
                Assigment_Id = 8,
                Description = "Assigment 8",
                SubmissionDateTime = new DateTime(2022, 09, 03),

            };
            Assigments.Add(assigment8);


            #endregion
        }
    }
}
