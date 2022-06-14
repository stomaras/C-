using PARTB.Database;
using PARTB.Repositories.AssigmentRepository;
using PARTB.View.AssigmentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.Controllers
{
    public class AssigmentController
    {

        private ApplicationContext db = new ApplicationContext();

        private AssigmentRepository assigmentRepository;

        public AssigmentController()
        {
            assigmentRepository = new AssigmentRepository(db);
        }

        public void ReadingAssigments()
        {
            try
            {
                PrintAssigment printAssigment = new PrintAssigment();
                var assigments = assigmentRepository.GetAllAssigments();
                printAssigment.PrintAssigments(assigments);

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
