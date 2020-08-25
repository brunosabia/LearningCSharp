using _51_MultipleInheritance.Entities;
using System;

namespace _51_MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            //Neste caso o combo device herda os métodos Scan e Print do Scanner e Printer respectivamente, e herda o ProcessDoc de Device.
            //Se ComboDevice herdasse da classe Scanner e Printer por eles terem seus respectivos ProcessDocs, ocorreria um erro.
            //Por esta razão é necessário criar duas interfaces separadamente para criar um contrato que os métodos Scan e Print sejam devidamente criados
           

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());


        }
    }
}
