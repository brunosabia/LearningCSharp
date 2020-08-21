using System;
using System.Collections.Generic;
using System.Text;

namespace _51_MultipleInheritance.Entities
{
    class ComboDevice : Device, IScanner , IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan Result";
        }
    }
}
