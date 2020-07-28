using _40_Personalized_Exceptions_Ex.Entities;
using _40_Personalized_Exceptions_Ex.Entities.Exceptions;
using System;
using System.Globalization;

namespace _40_Personalized_Exceptions_Ex
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.WriteLine();

                Console.Write("Enter the amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, limit);
                acc.Withdraw(amount);

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2",CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
