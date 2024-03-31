using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17_HW
{
    public class RegularAccountCalculate: ICalculate
    {
        public void CalculateInterest(Account account)
        {
            if (account is RegularAccount)
            {
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance >= 1000)
                    account.Interest -= account.Balance * 0.4;

                Console.WriteLine($"Расчет произведен, процентная ставка: {account.Interest}");
            }
            else
            throw new NotImplementedException(message:"Неверный тип аккаунта для расчета");
        }
    }
}
