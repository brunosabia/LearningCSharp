using System;
using System.Collections.Generic;
using System.Text;
using _49_ExInterface.Entities;

namespace _49_ExInterface.Services
{
    class PaymentService
    {



        public void ProcessPayment(Contract contract, IOnlinePaymentService paymentService)
        {

            double baseValue = contract.TotalValue / contract.Months;


            for (int i = 1; i <= contract.Months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);

                double intermediateValue = baseValue + paymentService.Interest(baseValue, i);

                double FinalValue = intermediateValue + paymentService.PaymentFee(intermediateValue);

                Installment install = new Installment(dueDate, FinalValue);

                contract.addInstallments(install);

            }

            Console.WriteLine("INSTALLMENTS: ");

            foreach (Installment item in contract.list)
            {

                Console.WriteLine(item.DueDate.ToString("dd/MM/yyyy") + " - " + item.Amount);
            }

        }
    }
}
