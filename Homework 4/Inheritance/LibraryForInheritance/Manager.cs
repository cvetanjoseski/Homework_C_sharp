using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForInheritance
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, double salary, string department ) : base(firstName, lastName, salary, Role.Manager)
        {
            Department = department;
        }
        public string Department { get; set; }
    }
}
