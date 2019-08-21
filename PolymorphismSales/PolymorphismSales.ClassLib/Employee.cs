using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSales.ClassLib
{
    public abstract class Employee : Entity, IPayable
    {
        protected string name;

        protected Employee(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }

        public abstract decimal Earnings();
        public decimal GetPaymentAmount()
        {
            decimal earnings = Earnings();
            return earnings - earnings * 0.15m;
        }
    }
}
