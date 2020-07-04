using System;

namespace ExDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta:");
            string nome = Console.ReadLine();

            Conta conta = new Conta(num, nome);

            Console.Write("Haverá depósito inicial (s / n)?");
            conta.depInicial(Console.ReadLine());
            

            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));
            

            Console.WriteLine(conta);


        }
    }
}
