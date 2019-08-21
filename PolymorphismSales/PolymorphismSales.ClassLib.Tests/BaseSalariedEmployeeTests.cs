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
    }
}
