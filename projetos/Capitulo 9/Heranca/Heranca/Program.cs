﻿using System.Globalization;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinnesAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinnesAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
               Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }






















            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);






















            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinnesAccount bacc = new BusinnesAccount(1002, "Maria", 0.0, 500.0);

            //// UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinnesAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //// DOWNCASTRING

            //BusinnesAccount acc4 = (BusinnesAccount)acc2;
            //acc4.Loan(100.0);

            ////BusinnesAccount acc5 = (BusinnesAccount)acc3;
            //if (acc3 is BusinnesAccount)
            //{
            //    //BusinnesAccount acc5 = (BusinnesAccount)acc3;
            //    BusinnesAccount acc5 = acc3 as BusinnesAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if(acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}
        }
    }
}