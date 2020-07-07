using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Constructors
        public HourContract()
        {

        }

        public HourContract (DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //methods
        public double totalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
