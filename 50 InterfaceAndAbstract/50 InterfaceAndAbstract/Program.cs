using _50_InterfaceAndAbstract.Model.Entities;
using _50_InterfaceAndAbstract.Model.Enums;
using System;


namespace _50_InterfaceAndAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Shape s1 = new Circle(){ Radius = 2.0, Color = Color.White};
                Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
                Console.WriteLine(s1);
                Console.WriteLine(s2);




            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
