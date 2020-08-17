using _48_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48_Interface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
    
    
        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}
