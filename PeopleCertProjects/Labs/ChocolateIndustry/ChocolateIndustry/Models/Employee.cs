using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Services;
using ChocolateIndustry.Repository;


namespace ChocolateIndustry.Models
{
    class Employee
    {

        private Guid _eid;

        public Guid Eid
        {
            get { return _eid; }
            set { _eid = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        private int _wage;

        public int Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        public Employee()
        {
            Eid = Guid.NewGuid();
            FirstName = RandomService.RandFirstName();
            LastName = RandomService.RandLastName();
            Age = RandomService.Age();
            Wage = RandomService.Wages();

        }

        

        public override string ToString()
        {
            return $"Employee {{ FirstName: {FirstName}, LastName: {LastName}, Age: {Age}, Wage: {Wage}}}";
        }





    }
}
