using AbstractMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AbstractMethods.Entities
{
    class Circle : Shape
    {

        public double Radius { get; set; }


        public Circle(Color color,double radius): base (color)
        {
            
            Radius = radius;
        }

        public override double Area()
        {
            return (Radius * Radius) * Math.PI;
        }

        public override string ToString()
        {
            return "Circle - "
                + "Color: " + Color
                + ", Radius: " + Radius.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
