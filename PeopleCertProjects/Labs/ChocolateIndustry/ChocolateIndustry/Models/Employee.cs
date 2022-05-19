using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Services;
using ChocolateIndustry.Repository;
using ChocolateIndustry.Interfaces;

namespace ChocolateIndustry.Models
{
    class Employee : IPeople
    {

        private Guid _eid;

        public Guid Eid
        {
            get { return _eid; }
            set { _eid = value; }
        }

        public string firstName { get; set; }

        public string lastName { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Sex sex { get; set; }
        private int _wage;

        public int Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        

        public Employee()
        {
            Eid = Guid.NewGuid();
            firstName = RandomService.RandFirstName();
            lastName = RandomService.RandLastName();
            Age = RandomService.Age();
            Wage = RandomService.Wages();
            sex = Sex.Female;

        }

        

        public override string ToString()
        {
            return $"Employee {{ FirstName: {firstName}, LastName: {lastName}, Age: {Age}, Wage: {Wage}}}";
        }





    }
}
