using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    static class StatClass
    {
        /*
         * The method Test3 belongs to this Class, which Class Program
         * 
         */
        public static void Test3(this Program p, int i)// binding will be done by this keyword, this parameter is only for binding the method with a class or a structure
            // will ignore the first parameter not the second
        {
            Console.WriteLine("Method 3 {0}", i);
        }

        // Factorial is a method bound to Int32 structure
        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }

        // I am going to add a method in String class in order to convert my string in propercase.
        // This method which i am going to add in String Class is an Extension Method.
        // Proper Case String : Every first character should converted into uppercase and remaining characters should converted into lower case
        // 1st step: is to convert whole string in lower case
        // 2nd step: identify every word and first character make it uppercase

        // hElLo hOw Are yoU
        //|
        //hello how are you
        //
        //hello => {'h','e','l','l','o'} => {'H','e','l','l','o'} => Hello
        //how => {'h','o','w'} => {'H','o','w'} => How
        //are
        //you
        public static string ToProper(this String OldStr)// binding this method with the Sealed String Class
        {
            if(OldStr.Trim().Length > 0)
            {
                String NewStr = null;
                OldStr = OldStr.ToLower();
                // find the number of words in the string
                string[] arr = OldStr.Split(' ');
                foreach(String str in arr)
                {
                    char[] chars = str.ToCharArray();
                    chars[0] = Char.ToUpper(chars[0]);
                    if(NewStr == null)// 1st time assigment of NewStr
                    {
                        NewStr = new string(chars);// this character array is converted back into string
                    } else// 2nd time concatenate NewStr
                    {
                        NewStr += ' ' + new string(chars);
                    }
                }
                return NewStr;
            }
            return OldStr;
        }
    }
}
