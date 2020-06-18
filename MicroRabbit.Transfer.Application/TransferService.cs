using MicroRabbit.Core.Bus;
using MicroRabbit.Transfer.Data;
using MicroRabbit.Transfer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _rep;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository rep, IEventBus bus)
        {
            _rep = rep;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLog()
        {
           return _rep.GetTransferLog();
        }
    }
}
