using Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * Tests:
                Employee emp1 = new Employee("Carlos", 10, 12.00);
                Employee emp2 = new OutsourcedEmployee("André", 10, 12.00, 20);

                Console.WriteLine(emp1.Payment());
            Console.WriteLine(emp2.Payment());
            */ 


            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0} data: ", i);
                Console.Write("Outsourced (y/n)? ");
                string outs = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outs == "n")
                {

                    Employee emp = new Employee(name, hours, valuePerHour);

                    employees.Add(emp);
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Employee emp = new OutsourcedEmployee(name, hours, valuePerHour, additional);

                    employees.Add(emp);

                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS - ");
            foreach (Employee item in employees)
            {
                Console.WriteLine("{0} - $ " + item.Payment().ToString("F2"),item.Name,CultureInfo.InvariantCulture); 
            }

        }
    }
}
