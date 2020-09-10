using _63_Comparison.Entities;
using System;
using System.Collections.Generic;

namespace _63_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Esta linha abaixo é chamada de COMPARISON - DELEGATE, onde o método SORT recebe um método(SEM OS PARENTESES) que passa as regras usadas, neste caso, para ordenar a lista.
            list.Sort(CompareProducts);



            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        //método responsavel pela regra da comparação entre os dois products pq tem uma implementação padrão COMPARISON
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

    }
}
