using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01T7M10.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount +5;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual string AccountData() {
            return $"\n\nAccount Data:" +
                $"\n\tDate: {DateTime.Now.ToLongDateString()}," +
                $"\n\tHolder: {Holder}," +
                $"\n\tBalance:{Balance:f2}";
        }
    }
}
