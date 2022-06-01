using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Views.TrainerView
{
    public class InputTrainer : IInputTrainer
    {
        public Trainer GetAllData()
        {
            Console.WriteLine("Get All Data From Console...");
            throw new NotImplementedException();
        }

        public Trainer GetDataForEdit()
        {
            Console.WriteLine("Get All Data From Console to Edit...");
            throw new NotImplementedException();
        }

        public int GetIdForDelete()
        {
            Console.WriteLine("Get Id For Delete...");
            throw new NotImplementedException();
        }

        public string GetNameForDelete()
        {
            Console.WriteLine("Get Name For Delete...");
            throw new NotImplementedException();
        }
    }
}
