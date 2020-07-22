using AbstractMethods.Entities;
using AbstractMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)?");
                char shap = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shap == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                   shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Overview:");
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.ToString() + ", Area: "+ item.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        
        
        }
    }
}
