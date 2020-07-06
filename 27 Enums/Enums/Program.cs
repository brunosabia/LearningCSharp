using Enums.Entities;
using Enums.Entities.Enums;
using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            Console.WriteLine(order.Status);

            //converter ENUM para String:
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);



            //Converter String para ENUM:
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


            //testes
            Console.WriteLine("Pagamento recebido:");
            string received = Console.ReadLine();
            
            if(received != "nao" && received != "não"  )
            {
                order.Status = Enum.Parse<OrderStatus>("Processing");
                Console.WriteLine(order);
            }
            
            order.Status = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(order);
        
        }
    }
}
