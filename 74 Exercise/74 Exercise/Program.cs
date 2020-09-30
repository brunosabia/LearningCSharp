using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using _74_Exercise.Entities;

namespace _74_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();
            List<Employee> list = new List<Employee>();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] inputs = sr.ReadLine().Split(',');
                        string name = inputs[0];
                        string email = inputs[1];
                        double salary = double.Parse(inputs[2],CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }
                }

                Salaries(list);

                Console.WriteLine(SalariesSum(list));


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Salaries(List<Employee> employees)
        {
            Console.Write("Type the salary:");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is more than " + value);
            var salaries = employees.Where(obj => obj.Salary > value).OrderBy(obj => obj.Email).Select(obj => obj.Email);

            foreach (string email in salaries)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();
        }

        static string SalariesSum(List<Employee> employees)
        {
            Console.WriteLine("Sum of the employee's salaries whose name starts with 'M'");
            var sum = employees.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

            return sum.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
