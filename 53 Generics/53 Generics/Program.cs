using System;

namespace _53_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //na hora da instanciação vc passa o tipo dos dados que serão usados na classe instanciada
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x =int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());

        }
    }
}
