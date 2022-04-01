using System;

namespace LibraryForInheritance
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role;
        public void PrintInfo(string FirstName,string LastName,double Salary)
        {
            Console.WriteLine($"Employee {FirstName} {LastName} has salary of {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }

        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            this.Role = role;
        }
    }
}
