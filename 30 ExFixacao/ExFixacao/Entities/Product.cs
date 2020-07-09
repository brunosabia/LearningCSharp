using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ExFixacao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
