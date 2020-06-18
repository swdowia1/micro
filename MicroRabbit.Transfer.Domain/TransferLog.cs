using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public int TarnsferAmoun { get; set; }
    }
}
