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
        public int ZipCode { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Product> Products { get; set; }

        public Shop(string shopName, string street, string area)
        {
            int NumOfEmployees = RandomService.Number(10, 100);
            int NumOfProducts = RandomService.Number(100, 1000);
            Id = Guid.NewGuid();
            ShopName = shopName;
            Street = street;
            Area = area;
            ZipCode = RandomService.Number(1, 1000);
            Number = RandomService.Number(1, 300);
            Employees = GenerateEmployees(NumOfEmployees);
            Products = GenerateProducts(NumOfProducts);
        }

        public void AddEmployee(List<Employee> employees, Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(List<Employee> employees, Employee employee)
        {
            employees.Remove(employee);
        }

        public List<Employee> GenerateEmployees(int NumOfEmployees)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < NumOfEmployees-1; i++)
            {
                Employee employee = Employee.GetEmployee();
                employees.Add(employee);
            }
            return employees;
        }

        public List<Product> GenerateProducts(int NumOfProducts)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < NumOfProducts-1; i++)
            {
                Product product = Product.GetProduct();
                products.Add(product);
            }
            return products;
        }
    }
}
