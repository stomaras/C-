using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    /*
     * O stands for open closed principle 
     * it states two objects should be open to extension but closed for modification
     * people who applied at our company and now we are gonna give them jobs and so because we are gonna hire them we
     * have to give them an employee account and we will take the information we have the first and last name and we will create an account which
     * again is simply first and last name and an email address
     * Open Closed Principle says that we should have the ability to be closed for modification but open for extension
     * We will have a way to identifying than an employee is a manager
     * When something goes to production only reason something might change is because there is a bug on the system.
     * I have a list of IApplicant Model and i can put any type of applicant here , any type of class that implements the IApplicant Model Interface.
     * We have the Accounts, we have the ManagerAccounts, we have the ExecutiveAccounts and we implement IAccounts, each of these makes something different in the 
     * Create method
     * In the other side instead of having PersonModel , we have IApplicantModel person -> This is a PersonModel or a ManagerModel or a ExecutiveModel
     * IApplicantModel have FirstName, LastName and an AccountProcessor, we can use these three to build our EmployeeModel
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel {FirstName = "Tim", LastName = "Corey"},
                new ManagerModel {FirstName = "Sue", LastName = "Storm"},
                new ExecutiveModel {FirstName = "Nancy", LastName = "Roman"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName}{emp.LastName}: {emp.EmailAddress} IsManager : {emp.IsManager} IsExecutive {emp.IsExecutive}");
            }
            Console.ReadLine();


        }
    }
}
