using System;
using Xunit;

namespace PolymorphismSales.ClassLib.Tests
{
    public class BaseSalariedEmployeeTests
    {
        [Fact]
        public void Earnings_ReturnsRightAmount()
        {
            BaseSalariedEmployee employee = new BaseSalariedEmployee("Name", 20000);
            decimal expected = employee.Salary;
            decimal actual = employee.Earnings();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetPaymentAmount_ReturnsRightAmount()
        {
            BaseSalariedEmployee employee = new BaseSalariedEmployee("Name", 20000);
            decimal earnings = employee.Earnings();
            decimal expected = earnings - earnings * 0.15m;
            decimal actual = employee.GetPaymentAmount();
            Assert.Equal(expected, actual);
        }
    }
}
