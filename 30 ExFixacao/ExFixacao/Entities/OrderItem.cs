using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExFixacao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        Product Prod { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price,Product prod)
        {
            Quantity = quantity;
            Price = price;
            Prod = prod;
        }


        public double SubTotal() 
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Prod.Name + ", $"
                + Prod.Price + ", Quantity: "
                + Quantity + ", Subtotal: $"
                + SubTotal().ToString("F2",CultureInfo.InvariantCulture);
                

        }

    }
}
