using _49_ExInterface.Services;
using System;
using _49_ExInterface.Entities;
using System.Globalization;

namespace _49_ExInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, amount, months);

            PaymentService paymentservice = new PaymentService();

            paymentservice.ProcessPayment(contract,new PaypalService());
        }
    }
}
