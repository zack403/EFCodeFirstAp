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
            Console.ReadLine();

            InsertEmployee();
        } 
        private static void InsertEmployee()
        {
            //DateTime now = new DateTime(10 - 01 - 2018);
            //DateTime.MinValue.Ticks dob = new DateTime(19 / 06 / 1992);
            var newemp = new Employee()
            {
                //ID = int.Parse(Guid.NewGuid().ToString()),
                FirstName = "Zack",
                LastName = "Aminu",
                CompanyName = "Netop Business Systems Limited",
                JobLevel = "Entry",
                JobRole = "Software Developer",
                //Salary = 100000,
                //YearOfEmployment = now,
                //DateOfBirth = dob


            };

            using (var context = new Context())
            {
                var del = context.Employees.FirstOrDefault();
                context.Employees.Remove(del);
                context.SaveChanges();
            }
        }
        
    }
}