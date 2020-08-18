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

        public ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay,ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }


        public void ProcessInvoice(CarRental carRental)
        {
            //subtração de data e atribuicao a variável duration
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                //atribui as horas vezes o preco por hora (arredondando pra cima com o Math.Ceiling) 
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
