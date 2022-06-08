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
        public int EnterTrainerIdToDelete()
        {
            throw new NotImplementedException();
        }

        public Trainer EnterTrainerToCreate()
        {
            Helper helper = Factory.CreateHelper();
            printTrainer.CreateTrainerFirstName();
            // Validation of Trainer first name
            string firstName = helper.CheckValidFirstName(Console.ReadLine());

            printTrainer.CreateTrainerLastName();
            // Validation of Trainer last name
            string lastName = Console.ReadLine();

            printTrainer.CreateTrainerSubject();
            // Validation of Trainer Subject
            string subject = Console.ReadLine();

            Trainer trainerToCreate = new Trainer(firstName, lastName, subject);
            return trainerToCreate;
        }

        public Trainer EnterTrainerToUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
