using _52_IComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace _52_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file3.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
