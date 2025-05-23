using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01.Entities.Exceptions;

namespace Exercise01.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; } = 0;
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new WithdrawException("The amount exceeds withdraw limit");
            }else if(amount > Balance)
            {
                throw new WithdrawException("Not enough balance");
            }
                Balance -= amount;
        }
    }
}
