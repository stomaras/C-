using Ptolemeos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos.Views.TrainerView
{
    public interface IInputTrainer
    {
        int GetIdForDelete();
        string GetNameForDelete();
        Trainer GetAllData();
        Trainer GetDataForEdit();
    }
}
