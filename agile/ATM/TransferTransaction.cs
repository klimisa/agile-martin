using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile.ATM
{
    public class TransferTransaction: ITransaction
    {
        private readonly ITransferUI _transferUI;

        public TransferTransaction(ITransferUI transferUI)
        {
            _transferUI = transferUI;
        }

        public void Execute()
        {
            Console.WriteLine("Execute Transfer Transaction.");
            _transferUI.RequestTransferAmount();
        }
    }
}
