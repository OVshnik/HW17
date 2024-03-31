using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17_HW
{
    public class SalaryAccountCalculate : ICalculate
    {
        public void CalculateInterest(Account account)
        {
            if (account is SalaryAccount)
            {
                account.Interest = account.Balance * 0.5;

                Console.WriteLine($"Расчет произведен, процентная ставка: {account.Interest}");
            }
            else
                throw new NotImplementedException(message: "Неверный тип аккаунта для расчета");
        }
    }
}
