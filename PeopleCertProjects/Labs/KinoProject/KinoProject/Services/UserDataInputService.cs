using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject.Services
{
    public class UserDataInputService
    {
        

        private bool _kinoBonus;

        public bool KinoBonus
        {
            get { return _kinoBonus; }
            set { _kinoBonus = value; }
        }

        private int _numbers;

        public int Numbers
        {
            get { return _numbers; }
            set { _numbers = value; }
        }

        private bool _isUnique;

        public bool IsUnique
        {
            get { return _isUnique; }
            set { _isUnique = value; }
        }


        public List<int> UserNumbers { get; private set; }

        public UserDataInputService()
        {
            
            UserNumbers = new List<int>();
            
            for(int i=0; i<=5; i++)
            {
                if (i == 0)
                {
                    int num = EnterValidNumber();
                    UserNumbers.Add(num);
                }
                else
                {
                    bool isUnique = false;
                    int num;
                    while (!isUnique)
                    {
                        num = EnterValidNumber();
                        isUnique = CheckUniqueness(UserNumbers, num);
                        if (isUnique == true)
                        {
                            UserNumbers.Add(num);
                        }
                        else
                        {
                            PrintService.IsNotUniqueUserNumber();
                        }
                    }
                }
            }

            KinoBonus = PlayWithKinoBonus();
            PrintKinoNumbers();
        }

        public bool CheckUniqueness(List<int> UserNumbers, int number)
        {
            for(int i=0; i<= UserNumbers.Count-1; i++)
            {
                if(UserNumbers[i] == number)
                {
                    return false;
                }
            }
            return true;
        }

        public int EnterValidNumber()
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
            if(input == "Y" || input == "y")
            {
                playWithKinoBonus = true;
            }
            if(input == "N" || input == "n")
            {
                playWithKinoBonus = false;
            }
            return playWithKinoBonus;
        }


        private void PrintKinoNumbers()
        {
            Console.WriteLine("User Inputs:\n");
            for(int i=0; i<= UserNumbers.Count-1; i++)
            {
                if(i < 1)
                {
                    Console.WriteLine($"{i + 1}st User Number is {UserNumbers[i]}");
                } else if (i == 1)
                {
                    Console.WriteLine($"{i + 1}nd User Number is {UserNumbers[i]}");
                } else if(i == 2)
                {
                    Console.WriteLine($"{i + 1}rd User Number is {UserNumbers[i]}");
                }
                else
                {   
                    Console.WriteLine($"{i + 1}th User Number is {UserNumbers[i]}");
                }
            }
        }

        
        
        

        
        private bool CheckIfIsNumber(string num)
        {
            int numeric;
            bool isNumber = int.TryParse(num, out numeric);
            return isNumber;
        }

    }

    
}
