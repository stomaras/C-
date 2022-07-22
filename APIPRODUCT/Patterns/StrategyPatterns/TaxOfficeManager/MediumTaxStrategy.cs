using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StrategyPatterns.TaxOfficeManager
{
    public class MediumTaxStrategy : ITaxStrategy
    {

        Func<int, int, bool> precariat;
        Func<int, int, bool> proletariat;
        Func<int, int, bool> middleClass;
        Func<int, int, bool> upperMiddleClass;
        Func<int, int, bool> rich;
        Func<int, int, bool> precariatWithManyKids;
        Func<int, int, bool> proletariatWithManyKids;
        Func<int, int, bool> middleClassWithManyKids;
        Func<int, int, bool> upperMiddleClassWithManyKids;
        Func<int, int, bool> richWithManyKids;
        Func<int, bool> millionaire;
        List<double> amountOfTaxes;

        public MediumTaxStrategy()
        {
            amountOfTaxes = new List<double>();

            precariat = Precariat;
            proletariat = Proletariat;
            middleClass = MiddleClass;
            upperMiddleClass = UpperMiddleClass;
            rich = Rich;
            precariatWithManyKids = PrecariatWithManyKids;
            proletariatWithManyKids = ProletariatWithManyKids;
            middleClassWithManyKids = MiddleClassWithManyKids;
            upperMiddleClassWithManyKids = UpperMiddleClassWithManyKids;
            richWithManyKids = RichWithManyKids;
            millionaire = Millionaire;
        }
        public List<double> CalculateTaxs(List<Employee> employees)
        {

            foreach (var emp in employees)
            {

                if (precariat.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.02);
                }
                else if (precariatWithManyKids.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(0);
                }
                else if (proletariat.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.08);
                }
                else if (proletariatWithManyKids.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.04);
                }
                else if (middleClass.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.12);
                }
                else if (middleClassWithManyKids.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.07);
                }
                else if (upperMiddleClass.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.25);
                }
                else if (upperMiddleClassWithManyKids.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.20);
                }
                else if (rich.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.35);
                }
                else if (richWithManyKids.Invoke(emp.NumOfKids, emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.30);
                }
                else if (millionaire.Invoke(emp.AnnualIncome))
                {
                    amountOfTaxes.Add(emp.AnnualIncome * 0.50);
                }
            }
            return amountOfTaxes;
        }


        /*
         * Delegates For Calculate Amount Of Tax for each use case
         * 
         */

        /*
         * Delegates For Calculate Amount Of Tax for each use case
         * 
         */
        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is lower than 10.000 and kids less than zero
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool Precariat(int numOfKids, int annualIncome)
        {
            if (numOfKids <= 2 && annualIncome <= 20.000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 20.000 and less than 40.000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool Proletariat(int numOfKids, int annualIncome)
        {
            if (numOfKids <= 2 && (annualIncome > 20.000 && annualIncome <= 40.000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 40.000 and less than 100.000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool MiddleClass(int numOfKids, int annualIncome)
        {
            if (numOfKids <= 2 && (annualIncome > 40.000 && annualIncome <= 100.000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 100.000 and less than 200.000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool UpperMiddleClass(int numOfKids, int annualIncome)
        {
            if (numOfKids <= 2 && (annualIncome > 100.000 && annualIncome <= 200.000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 200.000 and less than 1000000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool Rich(int numOfKids, int annualIncome)
        {
            if (numOfKids <= 2 && (annualIncome > 200.000 && annualIncome <= 1000000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Millionaire(int annualIncome)
        {
            if (annualIncome > 1000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is lower than 10.000 and kids less than zero
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool PrecariatWithManyKids(int numOfKids, int annualIncome)
        {
            if (numOfKids > 2 && annualIncome <= 20.000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 20.000 and less than 40.000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool ProletariatWithManyKids(int numOfKids, int annualIncome)
        {
            if (numOfKids > 2 && (annualIncome > 20.000 && annualIncome <= 40.000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 40.000 and less than 100.000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool MiddleClassWithManyKids(int numOfKids, int annualIncome)
        {
            if (numOfKids > 2 && (annualIncome > 40.000 && annualIncome <= 100.000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 100.000 and less than 200.000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool UpperMiddleClassWithManyKids(int numOfKids, int annualIncome)
        {
            if (numOfKids > 2 && (annualIncome > 100.000 && annualIncome <= 200.000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Take Number of kids and annual income and check if the annual income is bigger than 200.000 and less than 1000000 and kids less than two
        /// </summary>
        /// <param name="numOfKids"></param>
        /// <param name="annualIncome"></param>
        /// <returns></returns>
        public bool RichWithManyKids(int numOfKids, int annualIncome)
        {
            if (numOfKids > 2 && (annualIncome > 200.000 && annualIncome <= 1000000))
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




   
