using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);
            Console.ReadLine();
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Constructor
        public Car()
        {
            this.Make = "Nissan";

        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

    }
}
