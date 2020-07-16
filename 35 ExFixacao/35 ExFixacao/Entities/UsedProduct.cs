﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _35_ExFixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }


        public sealed override string PriceTag()
        {
            
            return Name + "(used) $" + Price.ToString("F2",CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy")+ ")"; 
        }
    }
}
