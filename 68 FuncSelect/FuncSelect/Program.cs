using System;
using System.Collections.Generic;
using FuncSelect.Entities;
using System.Linq;

namespace FuncSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();


            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
             Delegate pela expressao Lambda
             
            Func<Product, string> func = p => p.Name.ToUpper();


            ou a linha lá de baixo com a expressao lambda inline:
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

             */



            Func<Product, string> func = NameUpper;

            //Cria uma lista que recebe uma função como parametro e executa a funcao nos itens da lista 
            //o "ToList()" precisa ser usado para transformar o resultado retornado em string em uma lista novamente
            List<string> result = list.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }


    }


    

}
