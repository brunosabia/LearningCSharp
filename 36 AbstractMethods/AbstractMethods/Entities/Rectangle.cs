using AbstractMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractMethods.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        

        public Rectangle(Color color,double width, double height) : base (color)
        {
            Width = width;
            Height = height;
        }


        
        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle - "
                + "Color: " + Color
                + ", Width: " + Width.ToString("F2",CultureInfo.InvariantCulture)
                + ", Height: " + Height.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
