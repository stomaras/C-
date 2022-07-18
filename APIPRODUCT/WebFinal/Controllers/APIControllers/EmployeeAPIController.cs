using Entities;
using Patterns.StrategyPatterns.TaxOfficeContext;
using Patterns.StrategyPatterns.TaxOfficeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFinal.DTOS.EmployeeDTO;

namespace WebFinal.Controllers.APIControllers
{
    public class EmployeeAPIController : BaseClassController
    {
        // GET: EmployeeAPI
        public ActionResult GetAllEmployeesWithAmountOfTaxes()
        {

            List<Employee> employees = (List<Employee>)superMarket.Employees.GetAll();

            TaxContext context = new TaxContext(new HighTaxStrategy());

            List<double> taxesAmount = context.CalculateTaxs();

            List<ReadEmployeeDTO> employeesToView= new List<ReadEmployeeDTO>();

            for (int i = 0; i <= employees.Count-1; i++)
            {
                ReadEmployeeDTO readEmployeeDTO = new ReadEmployeeDTO()
                {
                    firstName = employees[i].FirstName,
                    lastName = employees[i].LastName,
                    annualIncome = employees[i].AnnualIncome,
                    numOfKids = employees[i].NumOfKids,
                    amountOfTax = taxesAmount[i],
                };
                employeesToView.Add(readEmployeeDTO);
            }

            return Json(employeesToView, JsonRequestBehavior.AllowGet);
            //var employeesToView = superMarket.Employees.GetAll().Select(x => new ReadEmployeeDTO
            //{
            //    firstName = x.FirstName,
            //    lastName = x.LastName,
            //    numOfKids = x.NumOfKids,
            //    annualIncome = x.AnnualIncome,
            //    amountOfTaxes = taxesAmount,
            //});

            //return Json(employeesToView, JsonRequestBehavior.AllowGet);
            

        }
    }
}
