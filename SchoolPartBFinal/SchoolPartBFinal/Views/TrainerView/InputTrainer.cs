using SchoolPartBFinal.Entities;
using SchoolPartBFinal.FactoryObjects;
using SchoolPartBFinal.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.Views.TrainerView
{
    public class InputTrainer : IInputTrainer
    {

        PrintTrainer printTrainer = Factory.CreatePrintTrainer();
        Helper helper = Factory.CreateHelper();
        public int EnterTrainerIdToDelete()
        {

            printTrainer.EnterTrainerIDToDelete();
            string inputId = Console.ReadLine();
            int trainerID = helper.FilterIdIsNumber(inputId);
            

            return trainerID;
        }

        public Trainer EnterTrainerToCreate()
        {
            
            printTrainer.CreateTrainerFirstName();
            string firstName = helper.CheckValidFirstName(Console.ReadLine());

            printTrainer.CreateTrainerLastName();
            string lastName = helper.CheckValidLastName(Console.ReadLine());

            printTrainer.CreateTrainerSubject();
            string subject = helper.CheckValidSubject(Console.ReadLine());

            Trainer trainerToCreate = new Trainer(firstName, lastName, subject);
            return trainerToCreate;
        }

        public Trainer EnterTrainerToUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
