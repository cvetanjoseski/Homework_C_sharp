using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForInheritance
{
    public class CEO : Employee
    {
        public CEO(string firstName, string lastName, double salary, Role role, List<Employee> employees, int sharesProperty, double sharesPrice) : base(firstName, lastName, salary, role)
        {
            Employees = employees;
            SharesProperty = sharesProperty;
            _sharesPrice = sharesPrice;
        }
        public List<Employee> Employees { get; set; }
        public int SharesProperty { get; set; }
        private double _sharesPrice { get; set; }
        public void AddSharesPrice(double changeSharesPrice)
        {
            _sharesPrice = changeSharesPrice;
        }
        public void PrintEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine($"No.{Employees.IndexOf(employee)} {employee.FirstName}{employee.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + (SharesProperty * _sharesPrice);
        }
    }
}
