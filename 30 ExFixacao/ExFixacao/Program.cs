using ExFixacao.Entities;
using ExFixacao.Entities.Enums;
using System;
using System.Globalization;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            //Client Data
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);



            //Order Data
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


            Order order = new Order(DateTime.Now, status);


            //Products Data

            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #{0} item data: ",i);
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product prod = new Product(productName, productPrice);
                OrderItem orderIt = new OrderItem(productQuantity, productPrice,prod);

                order.AddItem(orderIt);
            }


            Console.WriteLine();



            //Summary
            Console.WriteLine("ORDER SUMMARY: ");
            Console.Write("Order Moment: ");
            Console.WriteLine(order.Moment.ToString(" dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("Order status: " + status);
            Console.WriteLine(client);
            Console.WriteLine("Order items: ");
            foreach (OrderItem item in order.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Price: $" + order.Total().ToString("F2",CultureInfo.InvariantCulture));
            

        }

    }
}
