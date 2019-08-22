using System;
using Xunit;

namespace PolymorphismSales.ClassLib.Tests
{
    public class SalesRepresentativeTests
    {
        [Fact]
        public void Earnings_ReturnsRightAmount()
        {
            SalesRepresentative employee = new SalesRepresentative("Name", 20000, 10000, 0.15);
            decimal expected = employee.Salary + employee.WeeklySales * Convert.ToDecimal(employee.CommisionRate);
            decimal actual = employee.Earnings();
            Assert.Equal(expected, actual);
        }
    }
}
