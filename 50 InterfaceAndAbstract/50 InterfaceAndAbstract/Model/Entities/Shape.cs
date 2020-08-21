using System;
using System.Collections.Generic;
using _50_InterfaceAndAbstract.Model.Enums;
using System.Text;

namespace _50_InterfaceAndAbstract.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
