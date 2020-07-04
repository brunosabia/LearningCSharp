using System;
using System.Dynamic;
using System.Globalization;

namespace Aprendendo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] produtos = Console.ReadLine().Split(' ');

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("O produto é: "+produtos[i]);
            }
            

            string produto1 = "Computador";
            //string produto2 = "Teclado";
            

            Console.WriteLine("Quantos do " + produto1 + " foram comprados hoje:");
            int quantidade = Int32.Parse(Console.ReadLine());

            int estoque = 15 - quantidade;
            Console.WriteLine("Existem " + estoque + " do produto " + produto1 + " sobrando.");



            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Faz com que o ponto(.) seja a separação das casas decimais em vez da virgula
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            

            */
            //Exercicio 

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura( mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string lastName = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

















        }


    }
}
