using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSales.ClassLib
{
    public class BaseSalariedEmployee : Employee
    {
        private decimal salary;

        public decimal Salary { get => salary; set => salary = value; }

        public override decimal Earnings()
        {
            return salary;
        }
    }
}
