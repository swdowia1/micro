using MicroRabbit.Transfer.Domain;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data
{
    public class TransferDBContext : DbContext
    {
        public TransferDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TransferLog> TransferLogs { get; set; }
    }
   
}
