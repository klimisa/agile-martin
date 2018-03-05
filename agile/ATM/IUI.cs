using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile.ATM
{
    public interface IUI: IDepositUI, IWithdrawalUI, ITransferUI
    {
    }
}
