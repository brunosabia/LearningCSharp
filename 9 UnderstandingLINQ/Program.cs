using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() {VIN= "A1", Make = "BMW", Model = "550i",StickerPrice = 55000, Year = 2008},
                new Car() {VIN= "B2", Make = "Toyota", Model = "4Runner",StickerPrice = 35000, Year = 2018},
                new Car() {VIN= "C3", Make = "BMW", Model = "745li",StickerPrice = 75000, Year = 2003},
                new Car() {VIN= "D4", Make = "Ford", Model = "Escape",StickerPrice = 25000, Year = 2009},
                new Car() {VIN= "E5", Make = "BMW", Model = "55i",StickerPrice = 57000, Year = 2010}
            };

            //LINQ QUERY 
            /* abaixo é como é usado uma pesquisa utilizando o metodo query do linq
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       select car;
             */

            //ou entao como ordenar a sua collection utilizando o padrão query
            /*  
             var orderedCars = from car in myCars
                               orderby car.Year descending
                               select car;

              */



            //LINQ METHOD - agora é o metodo mais padrão de C# para procurar uma collection
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //agora pra ordernar utilizando o padrão de C#
            //var orderedCars = myCars.OrderByDescending(p => p.Year);


            //exibir a VIN da primeira BWM
            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            //True for all verifica é a afirmação seguinte é verdadeira
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2003));

            //Exists pra saber se o atributo é encontrado dentre as opções da collection
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //Soma todos os valores
            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));


            //myCars.ForEach(p => p.StickerPrice -= 3000);

            //duas formas para exibir:
            //essa abaixo
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            /* 
             //ou entao essa
            foreach(var car in orderedCars)
            {
                Console.WriteLine("{0} {1}",car.Year, car.Model, car.VIN);
            }
            */


            Console.WriteLine(myCars.GetType());

            Console.ReadLine();

        }
    }


    class Car
    {
        public string VIN { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double StickerPrice { get; set; }
    }

}
