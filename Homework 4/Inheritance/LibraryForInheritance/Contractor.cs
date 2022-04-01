using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForInheritance
{
    public class Contractor : Employee
    {
        public Contractor(string firstName, string lastName, double salary,Manager responsible,double workHours,int payPerHour ) : base(firstName, lastName, salary, Role.Other)
        {
            Responsible = responsible;
            WorkHours = workHours;
            PayPerHour = payPerHour;
        }
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }

        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public void CurrentPostion()
        {
            Console.WriteLine($"The manager for {FirstName} {LastName} is in {Responsible.Department} department.");
        }               
    }
}
