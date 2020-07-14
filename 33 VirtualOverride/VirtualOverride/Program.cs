using VirtualOverride.Entities;
using System;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500.0);

            Account acc2 = new SavingsAccount(1001, "Alex", 500.0, 0.01);


            acc1.Withdraw(10.0);

            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            //Um teste para mostrar que mesmo fazendo um UPCASTING o metodo withdraw funciona da mesma forma pois o Override ainda nao foi concluido.
            //Apos o override ser incluido na classe SavingsAccount, o método é sobrescrito quando invocado pela subclasse
        }
    }
}