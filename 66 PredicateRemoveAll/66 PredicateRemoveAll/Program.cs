using System;
using System.Collections.Generic;
using _66_PredicateRemoveAll.Entities;

namespace _66_PredicateRemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate representa um método delegate que recebe um objeto do tipo T e retorna um valor Booleano
            //public delegate bool Predicate<in T>(T obj);


            List<Product> list = new List<Product>();

            list.Add(new Product("TV",900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case",80.90));

            //O método RemoveAll possui como parametro um predicate, onde vc passa uma regra que sera usada para correr a lista e separar os objetos
            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
