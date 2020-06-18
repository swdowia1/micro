using MicroRabbit.Transfer.Data;
using MicroRabbit.Transfer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLog();
    }
}
