using System;
using System.Collections.Generic;
using System.Text;

namespace _37_ExFixacao.Entities
{
    class Company : TaxPayer
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double anualIncome, int employeesNumber):base (name,anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Taxes()
        {
            if (EmployeesNumber <= 10)
            {
                double tax = AnualIncome * 0.16;
                return tax;
            }
            else
            {
                double tax =  AnualIncome * 0.14;
                return tax;
            }
        }
    }
}
