using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Enums
{
    public enum TransactionType
    {
        Withdrawal,
        Deposit,
        InboundTransfer,
        OutboundTransfer,
        Payment,
        Interest
    }
}
