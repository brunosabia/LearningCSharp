using System;
using System.Collections.Generic;
using System.Text;

namespace _40_Personalized_Exceptions_Ex.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
