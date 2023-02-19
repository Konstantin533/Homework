using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class CreditCard
    {
        public long numberCheck;
        public decimal currentSum;

        public CreditCard(long numberCheckInit,decimal currentSumInit)
        {
            numberCheck=numberCheckInit;
            currentSum=currentSumInit;
        }
        public void ChargeMoney()
        {
            
            Console.Write("\nВведите сумму которую хотите начислить: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            currentSum = currentSum + sum;
        }
        public void TakeoffMoney()
        {
            
            Console.Write("\nВведите сумму которую хотите снять: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            currentSum = currentSum - sum;
        }
        public decimal CurrentShow()
        {
            Console.Write($"\nТекущий баланс карты {numberCheck}: " + currentSum);
            return currentSum;
        }
    }
}
