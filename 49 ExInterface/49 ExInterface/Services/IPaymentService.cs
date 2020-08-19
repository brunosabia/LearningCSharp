using System;
using System.Collections.Generic;
using System.Text;

namespace _49_ExInterface.Services
{
    interface IPaymentService
    {
        public double Installment(double amount, int quantity);
    }
}
