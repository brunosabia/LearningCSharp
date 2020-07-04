using System;
using System.Globalization;

namespace VetorProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            double soma = 0;

            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] prod = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto:");
                string nome = Console.ReadLine();

                Console.Write("Digite o preco do produto:");
                double preco = double.Parse(Console.ReadLine());

                Console.WriteLine();
                prod[i] = new Produto { Nome = nome, Preco = preco };

                soma += preco;
            }

            double media = soma / n;
            Console.WriteLine("A média é: " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
