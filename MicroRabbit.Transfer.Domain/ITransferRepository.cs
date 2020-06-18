using System.Collections.Generic;

namespace MicroRabbit.Transfer.Domain
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLog();
    }
}
