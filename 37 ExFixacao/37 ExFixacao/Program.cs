using _37_ExFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _37_ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #{0} data", i);
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anual, employees));
                }
                else 
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anual, health));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes Paid:");

            double TotalTaxes = 0;

            foreach (TaxPayer item in list)
            {
                Console.WriteLine(item.Name + ": $" + item.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                TotalTaxes += item.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine("Total Taxes: $" + TotalTaxes.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
