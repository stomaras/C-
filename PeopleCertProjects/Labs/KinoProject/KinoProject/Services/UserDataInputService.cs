using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject.Services
{
    public class UserDataInputService
    {
        private int _firstNumber;

        public int FirstNumber
        {
            get { return _firstNumber; }
            set { _firstNumber = value; }
        }

        private int _secondNumber;

        public int SecondNumber
        {
            get { return _secondNumber; }
            set { _secondNumber = value; }
        }

        private int _thirdNumber;

        public int ThirdNumber
        {
            get { return _thirdNumber; }
            set { _thirdNumber = value; }
        }

        private int _fourthNumber;

        public int FourthNumber
        {
            get { return _fourthNumber; }
            set { _fourthNumber = value; }
        }

        private int _fifthNumber;

        public int FifthNumber
        {
            get { return _fifthNumber; }
            set { _fifthNumber = value; }
        }

        private int _sixthNumber;

        public int SixthNumber
        {
            get { return _sixthNumber; }
            set { _sixthNumber = value; }
        }


        private bool _kinoBonus;

        public bool KinoBonus
        {
            get { return _kinoBonus; }
            set { _kinoBonus = value; }
        }

        public List<int>  KinoNumbers{ get; private set; }

        public UserDataInputService()
        {
            KinoNumbers = new List<int>();
            FirstNumber = EnterNumber();
            KinoNumbers.Add(FirstNumber);
            SecondNumber = EnterNumber();
            KinoNumbers.Add(SecondNumber);
            ThirdNumber = EnterNumber();
            KinoNumbers.Add(ThirdNumber);
            FourthNumber = EnterNumber();
            KinoNumbers.Add(FourthNumber);
            FifthNumber = EnterNumber();
            KinoNumbers.Add(FifthNumber);
            SixthNumber = EnterNumber();
            KinoNumbers.Add(SixthNumber);
            KinoBonus = PlayWithKinoBonus();
            PrintKinoNumbers();
        }

        private bool PlayWithKinoBonus()
        {
            bool playWithKinoBonus = false; 
            Console.WriteLine("Do You Want to Play With Kino Bonus Enter: Y/N\n");
            string input = Console.ReadLine();
            while (input != "Y" && input != "N")
            {
                Console.WriteLine("Do You Want to Play With Kino Bonus Enter: Y/N\n");
                input = Console.ReadLine();
            }
            if(input == "Y")
            {
                playWithKinoBonus = true;
            }
            if(input == "N")
            {
                playWithKinoBonus = false;
            }
            return playWithKinoBonus;
        }

        private void PrintKinoNumbers()
        {
            Console.WriteLine("User Inputs:\n");
            for(int i=0; i<= KinoNumbers.Count-1; i++)
            {
                if(i < 1)
                {
                    Console.WriteLine($"{i + 1}st User Number is {KinoNumbers[i]}");
                } else if (i == 1)
                {
                    Console.WriteLine($"{i + 1}nd User Number is {KinoNumbers[i]}");
                } else if(i == 2)
                {
                    Console.WriteLine($"{i + 1}rd User Number is {KinoNumbers[i]}");
                }
                else
                {   
                    Console.WriteLine($"{i + 1}th User Number is {KinoNumbers[i]}");
                }
            }
        }
        
        private int EnterNumber()
        {
            string number = "";
            bool isNumber = false;

            int num = -1;
            // check if is number
            while (!isNumber)
            {
                Console.WriteLine("Enter Number between 1-80:\n");
                number = Console.ReadLine();
                isNumber = CheckIfIsNumber(number);
                if (isNumber == true)
                {
                    // check if range is between 1 and 80
                    num = Convert.ToInt32(number);
                    if (num >= 1 && num <= 80)
                    {
                        return num;
                    }
                    else
                    {
                        isNumber = false;
                    }
                }
            }

            return num;
        }

        private bool CheckIfIsNumber(string num)
        {
            int numeric;
            bool isNumber = int.TryParse(num, out numeric);
            return isNumber;
        }

    }

    
}
