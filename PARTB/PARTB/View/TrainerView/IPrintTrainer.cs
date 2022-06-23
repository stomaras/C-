using PARTB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.TrainerView
{
    public interface IPrintTrainer
    {
        void PrintTrainers(List<Trainer> trainers);

        void EnterTrainerDetailsToCreate(out (string firstName, string lastName, string subject) trainer);

        int EnterCourseId(List<int> CourseIds);

        void SuccessCreateMessageTrainer(Trainer trainer);
    }
}
