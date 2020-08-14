using _47_ExWorkingWithFiles.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace _47_ExWorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\myfolder\newfolder\file.csv";
            string targetPath = @"C:\temp\myfolder\newfolder\out\summary.csv";

            try
            {
                List<Product> prods = new List<Product>();

                using(FileStream fs = new FileStream(sourcePath, FileMode.Open))
                {
                    using(StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] items = null;
                            items = sr.ReadLine().Split(',');
                            string name = items[0];
                            double price = double.Parse(items[1],CultureInfo.InvariantCulture);
                            int quantity = int.Parse(items[2]);

                            Product product = new Product(name, price, quantity);
                            prods.Add(product);
                            
                        }
                    }
                }

                Directory.CreateDirectory(@"C:\temp\myfolder\newfolder\out");

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (Product product in prods)
                    {
                        sw.WriteLine(product.name + ", " + product.totalPrice().ToString("F2",CultureInfo.InvariantCulture));
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
