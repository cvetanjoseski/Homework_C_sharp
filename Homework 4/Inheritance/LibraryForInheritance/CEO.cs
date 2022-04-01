using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForInheritance
{
    public class CEO : Employee
    {
        public CEO(string firstName, string lastName, double salary, Role role) : base(firstName, lastName, salary, role)
        {
        }
        public List<Employee> Employees { get; set; }
        public int SharesProperty { get; set; }
        private double _SharesPrice { get; set; }
        public void AddSharesPrice(double changeSharesPrice)
        {
            _SharesPrice = changeSharesPrice;
        }
        public void PrintEmployees(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"No.{employees.IndexOf(employee)} {employee.FirstName}{employee.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + (SharesProperty * _SharesPrice);
        }
    }
}
