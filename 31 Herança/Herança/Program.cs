using Herança.Entities;
using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            //Balance é uma variável protected. Por isso a linha abaixo não funciona.
            //account.Balance = 200.0;
        }
    }
}
