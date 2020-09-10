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

            //this arrow function below is the shortened version of the CompareProducts method that will be delegated to the Sort method as a rule to execute the Sorting of the list.
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //this comp expression above can also be put directly as a paremeter on the following Sort method like this:
            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()))

            list.Sort(comp);



            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }


    }
}
