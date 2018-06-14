using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApp.Models
{
    public class Employee : BaseEntity
    {
        public string CompanyName { get; set; }
        public string JobRole { get; set; }
        public string JobLevel { get; set; }
        public DateTime? YearOfEmployment { get; set; }
        public int Salary { get; set; }

    }
}
