using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _54_GenericsExercise.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        //este é o método responsável pela comparação entre objetos do tipo Product
        public int CompareTo(object obj)
        {
            //SE O OBJT RECEBIDO NÃO FOR UM PRODUTO:
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a Product");
            }

            
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
