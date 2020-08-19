using System;
using System.Collections.Generic;
using System.Text;

namespace _49_ExInterface.Services
{
    class PaypalService : IPaymentService
    {
        public double Installment(double amount, int quantity)
        {
            double total = amount * 0.01 * quantity;
            amount += total;
            amount += amount * 0.02;

            return amount;

        }
    }
}
