using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17_HW
{
    public static class Calculator
    {
        
        internal static void Calculate(ICalculate calculate, Account account)
        {
            calculate.CalculateInterest(account);
        }

    }
}
