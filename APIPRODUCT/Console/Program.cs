﻿using Entities;
using MyDatabase;
using Patterns.StrategyPatterns.TaxOfficeContext;
using Patterns.StrategyPatterns.TaxOfficeManager;
using Repositories.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            UnitOfWork unit = new UnitOfWork(db);
            var products = unit.Products.GetAll();
            foreach (var pro in products)
            {
                System.Console.WriteLine(pro.Price);

            }

            var productsn = unit.Products.GetAll();
            foreach (var pro in productsn)
            {
                System.Console.WriteLine(pro.Price);
            }

            List<Employee> employees = (List<Employee>)unit.Employees.GetAll();
            System.Console.WriteLine(employees.Count);

            TaxContext context = new TaxContext(new HighTaxStrategy());

            List<double> tasks = context.CalculateTaxs();
            System.Console.WriteLine(tasks.Count);

            foreach (var item in tasks)
            {
                System.Console.WriteLine(item);
            }



        }
    }
}