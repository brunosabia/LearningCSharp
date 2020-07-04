using System;
using System.Security.Cryptography.X509Certificates;

namespace aprendendo3
{
    class Program
    {
        static void Main(string[] args)
        { 

            double x = 1;

            while (x >= 0)
            {
                Console.WriteLine("Digite um numero:");
                x = double.Parse(Console.ReadLine());
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F2"));

            }
        }
    }
}
