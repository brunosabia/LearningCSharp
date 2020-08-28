using _55_GetHashCodeAndEquals.Entities;
using System;

namespace _55_GetHashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("Maria", "maria@gmail.com");

            Client b = new Client("Alex", "alex@gmail.com");
            Client c = new Client("Manuela", "maria@gmail.com");

            Console.WriteLine(a.Equals(c));
            Console.WriteLine(a == c);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());
        }
    }
}
