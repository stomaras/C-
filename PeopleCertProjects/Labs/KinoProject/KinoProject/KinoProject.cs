using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoProject.Services;
namespace KinoProject
{
    class KinoProject
    {
        private UserDataInputService _userDataInputService;

        public UserDataInputService UserDataInputService
        {
            get { return _userDataInputService; }
            set { _userDataInputService = value; }
        }

        private ListComparisonService _listComparisonService;

        public ListComparisonService ListComparisonService
        {
            get { return _listComparisonService; }
            set { _listComparisonService = value; }
        }

        private DrawNumbersGeneration _drawNumbersGeneration;

        public DrawNumbersGeneration DrawNumbersGeneration
        {
            get { return _drawNumbersGeneration; }
            set { _drawNumbersGeneration = value; }
        }


        private bool _kinoBonus;

        public bool KinoBonus
        {
            get { return _kinoBonus; }
            set { _kinoBonus = value; }
        }


        public KinoProject()
        {
            
        }

        public void Start()
        {
            Options();
            UserDataInputService = new UserDataInputService();
            KinoBonus = UserDataInputService.KinoBonus;
            DrawNumbersGeneration = new DrawNumbersGeneration(KinoBonus);
            List<int> KinoNumbers = DrawNumbersGeneration.RandomNumbersGeneration;
            List<int> UserNumbers = UserDataInputService.UserNumbers;
            ListComparisonService listComparisonService = new ListComparisonService(UserNumbers, KinoNumbers);
            listComparisonService.CheckMatches(UserNumbers, KinoNumbers, KinoBonus);
        }

        public static void Options()
        {

            Console.WriteLine("Enter 6 numbers at total:\n");
            Console.WriteLine("Enter A number between: 1-80\n");
        }


    }
}
