using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAnkProblem
{
    public class DepositAccount : Account, IWithdraw, IDeposit
    {
        public DepositAccount(int numberofmonths, decimal balance, decimal intrestrate, Customer customer)
        {
            Customer = customer;
            base.Balance = balance;
            base.NumberOfMonths = numberofmonths;
            base.IntrestRate = intrestrate;
        }
        //public decimal Balance
        //{
        //    get;// { return balance; }
        //    set;// { balance = value; } 
        //}

        //public decimal IntrestRate { get; set; }
        //public int NumberOfMonths { get; set; }
        public Customer Customer { get; set; }

        public void DepositMoney(int Amount)
        {
            Balance += Amount;
        }
        public void WithdrawMoney(int Amount)
        {
            Balance -= Amount;
        }
        public override decimal CalculateIntrest()
        {
            if (Balance < 1000)
            {
                return 0;

            }
            else
            {
                return IntrestRate * NumberOfMonths;
            }
        }
        }

    }
