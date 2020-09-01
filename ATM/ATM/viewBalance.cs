using System;
namespace ATM
{
    public class viewBalance
    {
        public decimal Balance { get; private set; }
        public viewBalance (decimal balance)

        {
            Balance = balance;
        }
        public void Withdraw (decimal amount)
        {
            if (Balance >= amount)
                Balance -= amount;

            else
                throw new InsufficeintFundException();
        }
    }
}

