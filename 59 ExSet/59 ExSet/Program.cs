using _59_ExSet.Entities;
using System;
using System.Collections.Generic;

namespace _59_ExSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Course A = new Course();
            Course B = new Course();
            Course C = new Course();
            Course Total = new Course();

            Console.Write("How many students for course A?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                A.addUser(code);
                Total.addUser(code);
            }

            Console.Write("How many students for course B?");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                int code = int.Parse(Console.ReadLine());
                B.addUser(code);
                Total.addUser(code);
            }

            Console.Write("How many students for course C?");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int code = int.Parse(Console.ReadLine());
                C.addUser(code);
                Total.addUser(code);
            }

            Console.WriteLine("Total students: " + Total.Count());

       
        }
    }
}
