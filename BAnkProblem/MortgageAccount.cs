using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAnkProblem
{
    public class MortgageAccount:Account,IDeposit
    {
        public Customer Customer { get; set; }
        public MortgageAccount(int numberofmonths, decimal balance, decimal intrestrate, Customer customer)
        {
            Customer=customer;
            base.NumberOfMonths=numberofmonths;
            base.Balance=balance;
            base.IntrestRate=intrestrate;


        }
        public void DepositMoney(int Amount)
        {
            Balance -= Amount;
        }
        public override decimal CalculateIntrest()
        {
            if (Customer is Individual)
            {
                return 0;

            }
            else return 0;
        }
    }
}
