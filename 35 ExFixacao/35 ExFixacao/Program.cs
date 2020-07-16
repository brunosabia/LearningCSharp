using _35_ExFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _35_ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used or imported (c/u/i)?");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);       
                
                if(type == "i")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Product imp = new ImportedProduct(name, price, customsFee);

                    products.Add(imp);
                }else 
                if( type == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufDate = DateTime.Parse(Console.ReadLine());
                    Product used = new UsedProduct(name, price, manufDate);

                    products.Add(used);
                }
                else
                {
                    products.Add(new Product(name, price));
                    
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in products)
            {
                Console.WriteLine( item.PriceTag());
            }
        }
    }
}
