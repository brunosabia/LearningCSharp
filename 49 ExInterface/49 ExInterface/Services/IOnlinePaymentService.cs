using System;
using System.Collections.Generic;
using System.Text;

namespace _49_ExInterface.Services
{
    interface IOnlinePaymentService
    {
         double Interest(double amount, int months);
         double PaymentFee(double amount);
    }
}
