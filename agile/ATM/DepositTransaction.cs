using System;

namespace agile.ATM
{
    public class DepositTransaction: ITransaction
    {
        private readonly IDepositUI _depositUI;

        public DepositTransaction(IDepositUI depositUI)
        {
            _depositUI = depositUI;
        }

        public void Execute()
        {
            Console.WriteLine("Execute Deposit Tranaction.");
            _depositUI.RequestDepositAmount();
        }
    }
}