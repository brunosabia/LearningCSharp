using System;
using System.Dynamic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            do{
                Console.WriteLine("Digite a operação a ser realizada: (Exemplo: 3 + 2) Numeros negativos pra sair da aplicação");
                string[] vet = Console.ReadLine().Split(' ');

                valor1 = int.Parse(vet[0]);
                string operacao = vet[1];
                valor2 = int.Parse(vet[2]);


                if (operacao == "+")
                    Console.WriteLine(Soma(valor1, valor2));
                else if (operacao == "-")
                    Console.WriteLine(Subtracao(valor1, valor2));
                else if (operacao == "*")
                    Console.WriteLine(Multiplicacao(valor1, valor2));
                else if (operacao == "/")
                    Console.WriteLine(Divisao(valor1, valor2));

            }while (valor1 >= 0 && valor2 >= 0);

        }

        static int Soma(int a, int b)
        {
            int resultado = a + b;
            return resultado;
        }
        static int Subtracao(int a, int b)
        {
            int resultado = a - b;
            return resultado;
        }
        static int Multiplicacao(int a, int b)
        {
            int resultado = a * b;
            return resultado;
        }
        static int Divisao(int a, int b)
        {
            int resultado = a / b;
            return resultado;
        }


    }
}
