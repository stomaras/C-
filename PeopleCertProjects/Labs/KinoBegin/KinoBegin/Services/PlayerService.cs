using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBegin.Services
{
    class PlayerService
    {

        public PlayerService()
        {

        }

        public bool PlayWithKinoBonus()
        {
            bool playWithKinoBonus = false;
            PrintService.QuestionAboutKinoBonus();
            string input = Console.ReadLine();
            while (input != "Y" && input != "N")
            {
                PrintService.QuestionAboutKinoBonus();
                input = Console.ReadLine();
            }
            if (input == "Y" || input == "y")
            {
                playWithKinoBonus = true;
            }
            if (input == "N" || input == "n")
            {
                playWithKinoBonus = false;
            }
            return playWithKinoBonus;
        }
    }
}
