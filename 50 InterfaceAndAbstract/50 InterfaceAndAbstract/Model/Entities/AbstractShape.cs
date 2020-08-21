using System;
using System.Collections.Generic;
using System.Text;
using _50_InterfaceAndAbstract.Model.Enums;

namespace _50_InterfaceAndAbstract.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        //Mesmo sem haver implementação ainda é necessário criar o método do contrato da interface de forma abstrata
        public abstract double Area();
    }
}
