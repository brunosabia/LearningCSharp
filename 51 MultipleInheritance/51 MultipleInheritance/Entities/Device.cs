using System;
using System.Collections.Generic;
using System.Text;

namespace _51_MultipleInheritance.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);

    }
}
