using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAnkProblem
{
    
    public  class LoanAccount:Account,IDeposit

    {
        //public decimal Balance
        //{
        //    get;// { return balance; }
        //    set;// { balance = value; } 
        //}

        //public decimal IntrestRate { get; set; }
        //public int NumberOfMonths { get; set; }
        public LoanAccount(int numberofmonths,decimal balance, decimal intrestrate, Customer customer)
        {
            Customer = customer;
            base.Balance = balance;
            base.NumberOfMonths = numberofmonths;
            base.IntrestRate = intrestrate;
            
        }
        public Customer Customer { get; set; }
        public void DepositMoney(int Amount)
        {
            Balance += Amount;
        }
        public override decimal CalculateIntrest()
        {
            decimal value;
            if (Customer is Individual)
            {
                return value = IntrestRate * (NumberOfMonths - 3);
            }
            else if (Customer is Company)
            {
                return value = IntrestRate * (NumberOfMonths - 2);
            }
            else return 0;
        }
    }
}
