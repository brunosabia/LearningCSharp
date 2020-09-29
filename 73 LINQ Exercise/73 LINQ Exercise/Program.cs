using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using _73_LINQ_Exercise.Entities;

namespace _73_LINQ_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();
            //C:\temp\LINQTest.txt
            /*Conteudo do File
             

            Tv,900.00
            Mouse,50.00
            Tablet,350.50
            HD Case,80.90
            Computer,850.00
            Monitor,290.00
             
            */

            List<Product> list = new List<Product>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vs = sr.ReadLine().Split(',');
                        string name = vs[0];
                        double price = double.Parse(vs[1],CultureInfo.InvariantCulture);
                        list.Add(new Product(name, price));
                    }
                }

                FuncoesDoExercicio(list);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void FuncoesDoExercicio(List<Product> list)
        {
            var average = list.DefaultIfEmpty().Average(p => p.Price);
            Console.WriteLine("Average price: " + average.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

            var BelowAverage = list.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in BelowAverage)
            {
                Console.WriteLine(name);
            }
        }
    }
}
