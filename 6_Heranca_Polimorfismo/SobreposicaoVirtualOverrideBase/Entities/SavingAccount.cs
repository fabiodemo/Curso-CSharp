using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreposicaoVirtualOverrideBase.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate {  get; protected set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double balance)
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            //Balance -= amount;
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
