using System;
using System.Globalization;

namespace VetoresSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantas posições");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            double soma = 0;
            double media;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite a altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[i];
                
            }
            media = soma / n;
            Console.WriteLine("Média:" + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
