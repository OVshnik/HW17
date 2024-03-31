using Mod17_HW;
using System;
namespace Mod17_HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegularAccount regularAccount = new(900.6);
            ICalculate rCalculate = new RegularAccountCalculate();
            Calculator.Calculate(rCalculate, regularAccount);

            Console.WriteLine();

            SalaryAccount salaryAccount = new(1500.3);
            ICalculate sCalculate = new SalaryAccountCalculate();
            Calculator.Calculate(sCalculate, salaryAccount);

        }

    }
}