using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using _67_Action.Entities;

namespace _67_Action
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


            //Esse delegate do metodo action pode ser feita de 3 formas:
            //1- instanciando o Action e atribuindo a função criada:
            //Action<Product> act = UpdatePrice;
            
            //2-Instanciando o action e passando a função criada diretamente 
            Action<Product> act = p => { p.Price += p.Price * 0.1; };


            list.ForEach(act);

            //a linha acima tambem pode ser feita diretamente:
            // list.ForEach(p => { p.Price += p.Price * 0.1; });
            // e assim:
            // list.ForEach(UpdatedPrice)


            foreach (Product p in  list)
            {
                Console.WriteLine(p);
            }
        }

        //3- Criando o método separado seguindo o padrão do delegate e passando este método como parametro na hora da chamada
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
