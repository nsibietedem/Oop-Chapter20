using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAnkProblem
{
    public abstract  class Account:IDeposit
    {
        public decimal balance;
        public Customer? customer { get; set; }

        public decimal Balance 
        {
            get;// { return balance; }
            set;// { balance = value; } 
        }

        public decimal IntrestRate { get; set; }
        public int NumberOfMonths { get; set; }


        public virtual void  DepositMoney()//int amount
        {
           // Balance += amount;
        }
        public abstract decimal CalculateIntrest();
        

        
    }

}
