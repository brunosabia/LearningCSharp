using System;

namespace Teste3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Idade no ano que vem: " + func.anoQueVem());
            Console.WriteLine("Ano de nascimento: " + func.anoNascimento());
            func.imprimirFunc();
        }
    }
}
