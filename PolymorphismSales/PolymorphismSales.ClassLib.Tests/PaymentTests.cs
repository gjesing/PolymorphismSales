using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PolymorphismSales.ClassLib.Tests
{
    public class PaymentTests
    {
        [Fact]
        public void GetTotalAmount_ReturnsRightAmount()
        {
            decimal expected = 0;
            List <IPayable> iPayables = new List<IPayable>();
            BaseSalariedEmployee employee1 = new BaseSalariedEmployee("Employee1", 20000);
            expected += employee1.GetPaymentAmount();
            iPayables.Add(employee1);
            BaseSalariedEmployee employee2 = new BaseSalariedEmployee("Employee2", 25000);
            expected += employee2.GetPaymentAmount();
            iPayables.Add(employee2);
            BaseSalariedEmployee employee3 = new BaseSalariedEmployee("Employee3", 30000);
            expected += employee3.GetPaymentAmount();
            iPayables.Add(employee3);
            SalesRepresentative employee4 = new SalesRepresentative("Employee4", 35000, 10000, 0.15);
            expected += employee4.GetPaymentAmount();
            iPayables.Add(employee4);
            SalesRepresentative employee5 = new SalesRepresentative("Employee5", 40000, 15000, 0.2);
            expected += employee5.GetPaymentAmount();
            iPayables.Add(employee5);
            Invoice invoice1 = new Invoice(new List<Product>() { new Product("Product1", 50, 2) });
            expected += invoice1.GetPaymentAmount();
            iPayables.Add(invoice1);
            Invoice invoice2 = new Invoice(new List<Product>() { new Product("Product2", 30, 3), new Product("Product3", 100, 1) });
            expected += invoice2.GetPaymentAmount();
            iPayables.Add(invoice2);
            Invoice invoice3 = new Invoice(new List<Product>() { new Product("Product4", 10, 5), new Product("Product5", 70, 2), new Product("Product6", 120, 1) });
            expected += invoice3.GetPaymentAmount();
            iPayables.Add(invoice3);
            decimal actual = GetTotalPaymentAmount(iPayables);
            Assert.Equal(expected, actual);
        }
        private static decimal GetTotalPaymentAmount(List<IPayable> iPayables)
        {
            return iPayables.Sum(iPayable => iPayable.GetPaymentAmount());
        }
    }
}
