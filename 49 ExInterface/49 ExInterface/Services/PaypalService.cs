using System;
using System.Collections.Generic;
using System.Text;

namespace _49_ExInterface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private double InterestValue = 0.01;

        private double PaymentFeeValue = 0.02;


        public double Interest(double amount, int months)
        {
            return amount * InterestValue * months;
        }


        public double PaymentFee(double amount)
        {
            return amount * PaymentFeeValue;
        }

    }
}
