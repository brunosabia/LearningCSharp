using System;
using System.Collections.Generic;
using System.Text;

namespace _51_MultipleInheritance.Entities
{
    class Printer: Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer Processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }

        
    }
}
