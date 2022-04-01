using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForInheritance
{
    public class Contractor : Employee
    {
        public Contractor(string firstName, string lastName, double salary ) : base(firstName, lastName, salary, Role.Manager)
        {
        }
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return WorkHours * PayPerHour;
        }

    }
}
