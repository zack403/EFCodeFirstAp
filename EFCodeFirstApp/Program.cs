using EFCodeFirstApp.DataAccess;
using EFCodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("app is starting");
            Console.WriteLine("Code First in Action");
            Console.ReadLine();

            InsertEmployee();
        } 
        
        private static void InsertEmployee()
        {

            var newemp = new Employee()
            {
                ID =  Guid.NewGuid().ToString(),
                FirstName = "Zack",
                LastName = "Aminu",
                CompanyName = "Netop Business Systems Limited",
                JobLevel = "Entry",
                JobRole = "Software Developer",
                //Salary = 100000,
                YearOfEmployment = DateTime.Now,
                DateOfBirth = DateTime.Now, 


            };

            using (var context = new Context())
            {
                //var del = context.Employees.FirstOrDefault();
                //context.Employees.Remove(del);
                context.Employees.Add(newemp);
                context.SaveChanges();
            }
        }
        
    }
}