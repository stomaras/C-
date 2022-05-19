using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateIndustry.Interfaces;
using ChocolateIndustry.Services;

namespace ChocolateIndustry.Models
{
    class Shop : IBusiness
    {

        public Guid Id { get; set; }
        public string ShopName { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string ZipCode { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Product> Products { get; set; }

        public Shop(string shopName)
        {
            Id = Guid.NewGuid();
            ShopName = shopName;
            Number = RandomService.Number(1, 300);
        }

        public void AddEmployee(List<Employee> employees, Employee employee)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(List<Employee> employees, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
