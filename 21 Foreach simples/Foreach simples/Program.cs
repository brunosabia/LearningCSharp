using System;

namespace Foreach_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "André", "Carlos", "Junior" };

            foreach (string item in vect)
            {
                Console.WriteLine("O nome do usuário é {0}",item);
            }
        }
    }
}
