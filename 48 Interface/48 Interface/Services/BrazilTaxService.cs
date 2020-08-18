using System;
using System.Collections.Generic;
using System.Text;

namespace _48_Interface.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
