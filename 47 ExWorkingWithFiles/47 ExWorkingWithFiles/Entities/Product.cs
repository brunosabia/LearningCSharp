using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _47_ExWorkingWithFiles.Entities
{
    class Product
    {
        public string name { get; private set; }
        public double price { get; private set; }
        public int quantity { get; private set; }



        public Product() { }
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double totalPrice()
        {
            return price * quantity;
        }
    }
}
