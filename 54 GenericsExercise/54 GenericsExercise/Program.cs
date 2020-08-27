using _54_GenericsExercise.Entities;
using _54_GenericsExercise.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _54_GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService cs = new CalculationService();

            Product max = cs.Max(list);

            Console.WriteLine("Most Expensive: ");
            Console.WriteLine(max);
        }
    }
}
