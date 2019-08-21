using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSales.ClassLib
{
    public class Product
    {
        private string name;
        private decimal price;
        private int quantity;

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
