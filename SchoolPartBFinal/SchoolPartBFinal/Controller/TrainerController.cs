using SchoolPartBFinal.Entities;
using SchoolPartBFinal.FactoryObjects;
using SchoolPartBFinal.RepositoryServices.TrainerRepository;
using SchoolPartBFinal.Views.TrainerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Controller
{
    public class TrainerController
    {

        public void ReadingTrainers()
        {
            try
            {
                PrintTrainer pr = new PrintTrainer();
                TrainerRepository trainerRepository = new TrainerRepository();
                var trainers = trainerRepository.GetAll();
                
                pr.PrintTrainers(trainers);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateTrainer()
        {
            try
            {
                PrintTrainer pr = Factory.CreatePrintTrainer();
                InputTrainer inputTrainer = new InputTrainer();
                Trainer trainerToCreate = inputTrainer.EnterTrainerToCreate();
                TrainerRepository trainerRepository = Factory.CreateTrainerRepository();
                string message = trainerRepository.CreateTrainer(trainerToCreate);
                pr.PrintSuccessCreateTrainerMessage(message);


            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateTrainer()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteTrainer()
        {
            TrainerRepository trainerRepository = Factory.CreateTrainerRepository();
            try
            {
                PrintTrainer printTrainer = Factory.CreatePrintTrainer();
                InputTrainer inputTrainer = Factory.CreateInputTrainer();
                int trainerId = inputTrainer.EnterTrainerIdToDelete();
                List<int> trainerIDs = trainerRepository.GetAllTrainerIds();
                bool trainerToDeleteExists = trainerRepository.CheckIfTrainerIdExists(trainerIDs, trainerId);

                if (trainerToDeleteExists)
                {

                    Trainer trainerToDelete = trainerRepository.DeleteTrainer(trainerId);
                    string successDeleteMessage = $"Trainer with id {trainerToDelete.Id}, with trainer name {trainerToDelete.FirstName} , with subject {trainerToDelete.Subject} deleted successfully";
                    printTrainer.PrintSuccessDeleteTrainerMessage(successDeleteMessage);

                }
                else
                {
                    string failureDeleteMessage = $"Trainer with id {trainerId} does not exists!";
                    printTrainer.PrintFailureDeleteTrainerMessage(failureDeleteMessage);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
