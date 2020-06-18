using MicroRabbit.Transfer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDBContext _ctx;

        public TransferRepository(TransferDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLog()
        {
            return _ctx.TransferLogs;
        }
    }
}
