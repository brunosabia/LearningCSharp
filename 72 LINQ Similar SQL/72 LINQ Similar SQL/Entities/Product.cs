using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _72_LINQ_Similar_SQL.Entities
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }


        public Product(int iD, string name, double price, Category category)
        {
            ID = iD;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return ID + ": " + Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Category.Name;
        }
    }
}