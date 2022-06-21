using PARTB.Database;
using PARTB.Models;
using PARTB.Repositories.CourseRepository;
using PARTB.Repositories.TrainerRepository;
using PARTB.View.TrainerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Controllers
{
    public class TrainerController
    {
        private ApplicationContext db = new ApplicationContext();

        private TrainerRepository trainerRepository;
        private CourseRepository courseRepository;
        public TrainerController()
        {
            trainerRepository = new TrainerRepository(db);
            courseRepository = new CourseRepository(db);
        }

        public void ReadingTrainers()
        {
            try
            {
               PrintTrainer pr = new PrintTrainer();
               var trainers =  trainerRepository.GetAllTrainers();
               pr.PrintTrainers(trainers);
               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateTrainers()
        {
            try
            {
                PrintTrainer pr = new PrintTrainer();
                (string firstName, string lastName, string subject) trainerDetails = ("", "", "");
                pr.EnterTrainerDetailsToCreate(out trainerDetails);
                List<int> courseIds = courseRepository.GetAllCoursesIds();
                int trainerCourseId = pr.EnterCourseId(courseIds);
                Trainer trainer = new Trainer()
                {
                    FirstName = trainerDetails.firstName,
                    LastName = trainerDetails.lastName,
                    Subject = trainerDetails.subject,
                    CourseId = trainerCourseId
                };
                trainerRepository.AddTrainer(trainer);
                pr.SuccessCreateMessageTrainer(trainer);
                
               
            
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void ErrorService()
        {
            Console.WriteLine("This input does not exists try again or Press E (or) e to exit !!!");
        }
    }
}
