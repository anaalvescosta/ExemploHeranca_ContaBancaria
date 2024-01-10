using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01T7M10.Entities
{
    internal class SavingsAccount: Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, 
            double interestRate):base(number, holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            Balance -= amount;
        }
        public override string AccountData()
        {
            return base.AccountData() +
                $"\n\tType: Savings Account," +
                $"\n\tInterest Rate: {InterestRate:f2}";
        }
    }
}
