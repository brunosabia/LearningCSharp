using Delegate.Services;
using System;

namespace Delegate
{
    //essa é a declaracao pro delegate:
    delegate double BinaryNumericOperation(double n1, double n2);
    
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            BinaryNumericOperation op1 = CalculationService.Max;

            double result = op(a, b);
            //double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);

            double result1 = op1(a, b);
            Console.WriteLine(result1);
        }
    }
}
