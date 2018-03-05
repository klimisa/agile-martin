using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile.ATM
{
    public class WithdrawalTransaction: ITransaction
    {
        private readonly IWithdrawalUI _withdrawalUI;

        public WithdrawalTransaction(IWithdrawalUI withdrawalUI)
        {
            _withdrawalUI = withdrawalUI;
        }

        public void Execute()
        {
            Console.WriteLine("Execute Withdrawal Transaction.");
            _withdrawalUI.RequestWithdrawalAmount();
        }
    }
}
