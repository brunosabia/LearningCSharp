using System;
using System.Collections.Generic;
using System.Text;

namespace _37_ExFixacao.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome ,double healthExpenditures) :base (name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            if(AnualIncome < 20000)
            {
                double tax = AnualIncome * 0.15 - HealthExpenditures * 0.5;
                return tax;
            }
            else
            {
                double tax = AnualIncome * 0.25 - HealthExpenditures * 0.5;
                return tax;
            }
        }
    }

   
}
