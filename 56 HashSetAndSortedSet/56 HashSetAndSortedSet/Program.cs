using System;
using System.Collections.Generic;

namespace _56_HashSetAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            //Criando a coleção C e adicionando os valores de A ao C
            SortedSet<int> c = new SortedSet<int>(a);
            //Union : vou inserir no C todos os elementos do B que já nao estejam em C:
            c.UnionWith(b);
            PrintCollection(c);


            //Intersection - só adiciona os elementos que se repetem nas duas coleções
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);


            //difference - só os elementos que a coleção A tem e a colecao B não tem
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
