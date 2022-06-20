using PARTB.Database;
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
        public TrainerController()
        {
            trainerRepository = new TrainerRepository(db);
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

        public void ErrorService()
        {
            Console.WriteLine("This input does not exists try again or Press E (or) e to exit !!!");
        }
    }
}
