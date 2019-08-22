using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSales.ClassLib
{
    public class SalesRepresentative : BaseSalariedEmployee
    {
        protected decimal weeklySales;
        protected double commisionRate;

        public SalesRepresentative(string name, decimal salary, decimal weeklySales, double commisionRate) : base(name, salary)
        {
            WeeklySales = weeklySales;
            CommisionRate = commisionRate;
        }

        public decimal WeeklySales { get => weeklySales; set => weeklySales = value; }
        public double CommisionRate { get => commisionRate; set => commisionRate = value; }

        public override decimal Earnings()
        {
            return base.Earnings() + weeklySales * Convert.ToDecimal(commisionRate);
        }
    }
}
