using CodeWarsConsole.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole.Helpers.Helpers.HelpersFundamentals
{
    public class HelperFundamentals
    {
        /// <summary>
        /// 7ku
        /// Make a program that filters a list of strings and returns a list with only your friends name in it.
        ///
        ///If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...
        ////
        ////Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static IEnumerable<string> FriendOrNot(string[] names)
        {
            List<string> friends = GetNames(names);
            var realFriends = new List<string>();
            for (int i = 0; i < friends.Count; i++)
            {
                var friend = friends[i];
                if (friend.Length <=4)
                {
                    realFriends.Add(friend);
                }
            }
            return realFriends;
                              
                              
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<string> GetNames(string[] names)
        {
            List<string> namesList = new List<string>();    
            foreach (var item in names)
            {
                namesList.Add(item);
            }
            return namesList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int VowelCount(string str)
        {
            int vowelCount = 0;
            if (str != null)
            {
                var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u'};
                string pattern = @"[aeiou]{1,}+[/s]{1,}+[\]{1,}";
                Regex isValid = 
                foreach (char c in str.ToLower())
                {
                    if (vowels.Contains(c) || c.Equals(' ') || (c == '\'))
                    {
                        vowelCount++;
                    }
                }
            }
            return vowelCount;

        }

        public bool CheckIfIsAStringNumber(string number)
        {
            int n;
            bool isNumeric = int.TryParse(number, out n);
            if (isNumeric)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Validate(string number)
        {
            PrintView pr = Factory.Factory.CreatePrintView();
            Func<string, bool> isValid = ValidateString;
            while (!isValid.Invoke(number))
            {
                pr.EnterStringValueNotNullAndBetween1And10CharsLong();
                number = Console.ReadLine();
            }
            string returnNumber = "";

            List<char> chars = new List<char>();
            chars.AddRange(number);
            for (int i = 0; i <= chars.Count - 1; i++ )
            {
                 chars[0] = char.ToUpper(chars[0]);
                 returnNumber += chars[i];
            }
            
            return returnNumber;
        }

        public int GetNumber(bool isNumber, string number)
        {
            PrintView pr = new PrintView();
            if (isNumber)
            {
                return Convert.ToInt32(number);
            }
            else
            {
                while (!isNumber)
                {
                    pr.EnterNumericValueMessage();
                    number = Console.ReadLine();
                    int n;
                    isNumber = int.TryParse(number, out n);
                }

            }
            return Convert.ToInt32(number);
        }


        /*
         * Helper Delegates
         */

        public bool ValidateString(string astring)
        {
            
            if (astring != null)
            {
                int length = astring.Length;
                if (length >= 1 && length <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
