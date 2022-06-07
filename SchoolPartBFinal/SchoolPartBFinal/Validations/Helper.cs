using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPartBFinal.GeneralServices;

namespace SchoolPartBFinal.Validations
{
    public class Helper
    {

             
       
            /// <summary>
            /// Take A String (Year) And Check if this value is Numeric Type. Do the above mentioned process until user give a valid Year Number
            /// </summary>
            /// <param name="year"></param>
            /// <returns></returns>
            public int CheckYearType(string year)
            {
                int numericValue;
                bool isNumber = false;
                bool isValidRange = false;
                int HighestBoundYearOfBirth = DateTime.Now.Year - 70;
                int LowestBoundYearOfBirth = DateTime.Now.Year - 18;
                int InputYear = -1;
                while (!isNumber || !isValidRange)
                {
                    isNumber = int.TryParse(year, out numericValue);
                    
                    if (isNumber)
                    {
                        InputYear = numericValue;
                        Func<int, int, bool> IsInValidYears = IsInValidRange;
                        bool IsInValidYearsRange = IsInValidYears.Invoke(DateTime.Now.Year, InputYear);
                        if (IsInValidYearsRange)
                        {
                            isValidRange = true;
                        }
                        else
                        {
                            isValidRange = false;
                            GeneralPrintService.PrintYearMustBeInRange(HighestBoundYearOfBirth, LowestBoundYearOfBirth);
                            year = Console.ReadLine();
                        }
                    }
                    else
                    {
                        GeneralPrintService.PrintYearMustBeInteger();
                        year = Console.ReadLine();
                    }
                }
                return InputYear;
            }

            /// <summary>
            /// Take an input string and returns a valid month of birth for a student
            /// </summary>
            /// <param name="month"></param>
            /// <returns></returns>
            public int CheckMonth(string month)
            {
                int numericValue;
                bool isNumber = false;
                bool isValidRange = false;
                int InputMonth = -1;
                while (!isNumber || !isValidRange)
                {
                    isNumber = int.TryParse(month, out numericValue);

                    if (isNumber)
                    {
                        InputMonth = numericValue;
                        Func<int, bool> IsInValidMonths = IsInValidMonthRange;
                        bool IsInValidMonthsRange = IsInValidMonths.Invoke(InputMonth);
                        if (IsInValidMonthsRange)
                        {
                            isValidRange = true;
                        }
                        else
                        {
                            isValidRange = false;
                            GeneralPrintService.PrintMonthMustBeInRange();
                            month = Console.ReadLine();
                        }
                    }
                    else
                    {
                        GeneralPrintService.PrintMonthMustBeInteger();
                        month = Console.ReadLine();
                    }
                }
                return InputMonth;
            }

        public int CheckDay(string day)
        {
            int numericValue;
            bool isNumber = false;
            bool isValidRange = false;
            int InputDay = -1;
            while (!isNumber || !isValidRange)
            {
                isNumber = int.TryParse(day, out numericValue);

                if (isNumber)
                {
                    InputDay = numericValue;
                    Func<int, bool> IsInValidDay = ValidDayRange;
                    bool IsInValidDayRange = IsInValidDay.Invoke(InputDay);
                    if (IsInValidDayRange)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        isValidRange = false;
                        GeneralPrintService.PrintDayMustBeInRange();
                        day = Console.ReadLine();
                    }
                }
                else
                {
                    GeneralPrintService.PrintDayMustBeInteger();
                    day = Console.ReadLine();
                }
            }
            return InputDay;
        }

        public int CheckTuitionFees(string tuitionFees)
        {
            int numericValue;
            bool isNumber = false;
            bool isValidRange = false;
            int InputTuitionFees = -1;
            while (!isNumber || !isValidRange)
            {
                isNumber = int.TryParse(tuitionFees, out numericValue);

                if (isNumber)
                {
                    InputTuitionFees = numericValue;
                    Func<int, bool> isValidTuitionRange = ValidTuitonRange;
                    bool IsInValidTuitionFeesRange = isValidTuitionRange.Invoke(InputTuitionFees);
                     
                    if (IsInValidTuitionFeesRange)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        isValidRange = false;
                        int LowerTuition = 2100;
                        int HigherTuition = 2500;
                        GeneralPrintService.PrintTuitionFeesMustBeInRange(LowerTuition, HigherTuition);
                        tuitionFees = Console.ReadLine();
                    }
                }
                else
                {
                    GeneralPrintService.PrintTuitionMustBeANumber();
                    tuitionFees = Console.ReadLine();
                }
            }
            return InputTuitionFees;
        }

        /// <summary>
        /// A Function which used as a Delegate for the calculaton of valid year of birth range
        /// </summary>
        /// <param name="CurrentYear"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        public static bool IsInValidRange(int CurrentYear, int Year)
            {
                int validYear = CurrentYear - Year;
                bool IsOutOfLowestRange = validYear < 15;
                bool IsOutOfHighestRange = validYear > 70;
                bool IsYearWhichNotExists = validYear < 0;
                bool isValidRange = true;
                if (IsOutOfLowestRange || IsOutOfHighestRange || IsYearWhichNotExists)
                {
                    isValidRange = false;
                }
                else
                {
                    isValidRange = true;
                }
                return isValidRange;
            }

            /// <summary>
            /// A function whch used as a Delegate for the Calculation of valid month of birth range
            /// </summary>
            /// <param name="month"></param>
            /// <returns></returns>
            public static bool IsInValidMonthRange(int month)
            {
                bool isBiggerThanLowestMonthRange = month >= 1;
                bool isLowestThanBiggerMonthRange = month <= 12;
                if (isBiggerThanLowestMonthRange && isLowestThanBiggerMonthRange)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            /// <summary>
            /// A function which used as a Delegate for the calculation of valid day of birth range
            /// </summary>
            /// <param name="day"></param>
            /// <returns></returns>
            public static bool ValidDayRange(int day)
            {
                bool LowestDayRange = day >=1;
                bool HighestDayRange = day <= 30;
                if (LowestDayRange && HighestDayRange)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            /// <summary>
            /// A function which used as a Delegate for the calculation of valid tuition 2100 (or) 2500
            /// </summary>
            /// <param name="TuitionFees"></param>
            /// <returns></returns>
            public static bool ValidTuitonRange(int TuitionFees)
            {
                bool LowerTuition = (TuitionFees == 2100);
                bool HigherTuition = (TuitionFees == 2500);

                if (LowerTuition || HigherTuition)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



    }





}

