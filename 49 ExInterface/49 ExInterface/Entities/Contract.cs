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
        public int Months { get; set; }


        public Contract(int number, DateTime date, double totalValue,int months)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Months = months;

        }

        public void addInstallments(Installment installment)
        {
            list.Add(installment);
        }

    }
}
