using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForInheritance
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName) : base(firstName, lastName, 500, Role.Sales)
        {

        }

        private double _successSaleRevenue { get; set; }
      public void AddSuccessRevenue (double salaryChange)
        {
           _successSaleRevenue = salaryChange;
        }
        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                return base.GetSalary() + 500;
            }
            else if (_successSaleRevenue >= 2000 && _successSaleRevenue <= 5000)
            {
                return base.GetSalary() + 1000;
            }
            else return base.GetSalary()+1500;
        }
    }
}
