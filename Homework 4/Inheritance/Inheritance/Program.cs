using LibraryForInheritance;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee("Cvetan","Josheski",24534,Role.Sales);
            Console.WriteLine(employeeOne.FirstName);
            SalesPerson employeeTwo = new SalesPerson("Mile", "Petreski");
            
        }
    }
}
