using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //iniciar uma lista e ja passar valores iniciais
            List<string> list2 = new List<string> { "Maria", "Alex" };

            //criar uma lista vazia
            List<string> list = new List<string>();

            Console.Write("Digite um nome:");
            string nome = Console.ReadLine();

            //Adicionando e inserindo nomes

            list.Add(nome);
            list.Add("Maria");
            list.Add("André");
            list.Insert(2, "Carlos");
            list.Insert(3, "Alex");

            //imprimindo nomes

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //contando o tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            //find e a função do search

            string s1 = list.Find(Test);
            // a linha acima e o metodo Test poderiam ser substituidos por:
            // string s1 = list.Find(x => x[0] == 'A'
            Console.WriteLine("Primeiro A: {0}", s1);


            //funcao do search:
            static bool Test(string s)
            {
                return s[0] == 'A';
            }


            //Procurar o ultimo valor que dá match a condição
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo A: {0}", s2);


            //procura a posição do primeiro A
            int position = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição do A: "+ position);


            //procura a ultima posição de A
            int position2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição do A: "+ position2);

            
            //Filtrar a lista
            List<string> list3 = list.FindAll(x => x.Length == 5);
            foreach (string item in list3)
            {
                Console.WriteLine("Nome com 5 letras: "+ item);
            }

            //Remover da lista
            list.Remove("Alex");


            //Remover seguindo uma condição
            list.RemoveAll(x => x[0] == 'M');

            //Remover alguma posição especifica da lista
            list.RemoveAt(2);


            //Remover um range a partir de uma posição, uma quantidade de posições
            list.RemoveRange(0, 1);

            Console.WriteLine("-----------------------");
            //imprimir lista final
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
