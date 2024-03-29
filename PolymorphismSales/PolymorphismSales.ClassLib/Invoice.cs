﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSales.ClassLib
{
    public class Invoice : Entity, IPayable
    {
        protected List<Product> products = new List<Product>();

        public Invoice(List<Product> products)
        {
            Products = products;
        }

        public List<Product> Products { get => products; set => products = value; }

        public decimal GetPaymentAmount()
        {
            return products.Sum(product => product.Quantity * product.Price);
        }
    }
}
