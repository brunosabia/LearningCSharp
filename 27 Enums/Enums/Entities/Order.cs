using System;
using System.Collections.Generic;
using System.Text;
using Enums.Entities.Enums;

namespace Enums.Entities 
{
    class Order
    {
        public int Id;
        public DateTime Moment;
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + ", Moment: " + Moment + ", Status: " + Status + ".";
        }



    }
}
