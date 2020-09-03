using System;
using System.Collections.Generic;

namespace _60_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["User"] = "Maria";

            cookies["email"] = "Maria@gmail.com";

            cookies["phone"] = "991839281";

            cookies["phone"] = "837382317";
            //no caso como nao é permitida a repetição de keys, o phone é sobrescrito


            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            //se tentar imprimir uma key nao existe ocorrerá um erro. Ou tratar o erro com try catch, ou criar condicionais para que o erro nao quebre a execução
            //Console.WriteLine(cookies["email"]);

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }


            Console.WriteLine("Size: "+ cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
