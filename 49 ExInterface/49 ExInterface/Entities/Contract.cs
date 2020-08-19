using _49_ExInterface.Services;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _49_ExInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> list = new List<Installment>();
        public int Quantity { get; set; }
        public IPaymentService _paymentService { get; set; }


        public Contract(int number, DateTime date, double totalValue,int quantity, IPaymentService paymentService)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Quantity = quantity;
            _paymentService = paymentService;


        }

        public void addInstallments()
        {
            double value = TotalValue / Quantity;
            for (int i = 1; i <= Quantity; i++)
            {
                DateTime dueDate = Date.AddMonths(i);
                double amount = _paymentService.Installment(value, i);
                list.Add(new Installment(dueDate, amount ));
                value = TotalValue / Quantity;
            }
        }

        public void printList()
        {
            foreach (Installment item in list)
            {
                Console.WriteLine(item.DueDate.ToString("dd/MM/yyyy") + " - " + item.Amount.ToString("F2",CultureInfo.InvariantCulture));
            }
        }




    }
}
