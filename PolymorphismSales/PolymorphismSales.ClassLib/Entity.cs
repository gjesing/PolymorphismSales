using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSales.ClassLib
{
    public class Entity : IPersistable
    {
        protected int id;

        public int Id { get => id; }
    }
}
