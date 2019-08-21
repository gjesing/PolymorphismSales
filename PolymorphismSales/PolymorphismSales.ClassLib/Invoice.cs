using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSales.ClassLib
{
    class Invoice : IPayable
    {
        private List<Product> products = new List<Product>();

        protected List<Product> Products { get => products; set => products = value; }

        public decimal GetPaymentAmount()
        {
            return products.Sum(product => product.Price);
        }
    }
}
