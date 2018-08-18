using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetesBankAccount
{
    abstract class Account
    {
        //Properties
        public double AcctBal { get; set; }
        public double DepositAmt { get; set; }
        public double WithdrawAmt { get; set; }
        public string Name { get; set; }
        public int Counter { get; set; }


        public int GetCounter()
        {
            if (Counter < 3)
            {
                Counter++;
                //Console.WriteLine("Counter value is {0}", Counter);
                return Counter;
            }
            else
            {
                Counter = 1;
                //Console.WriteLine("Counter value is {0}", Counter);
                return Counter;
            }
        }
        public virtual void SetInterest(int acctType)
        {
            GetCounter();
            if (acctType == 1 && Counter == 3)
            {
                AcctBal = AcctBal * (1 + .02);
                //Console.WriteLine("interest paid");
            }
            else if (acctType == 2 && Counter == 3)
            {
                AcctBal = AcctBal * (1 + .05);
                //Console.WriteLine("interest paid");
            }


        }
        public double Deposit(double num)
        {
            AcctBal = AcctBal + num;
            return AcctBal;
        }
        public virtual double Withdraw(double num)
        {
            AcctBal = AcctBal - num;
            return AcctBal;
        }

        public virtual double CheckBalance()
        {
            return AcctBal;
        }
        public abstract void TransferFunds();

    }
}