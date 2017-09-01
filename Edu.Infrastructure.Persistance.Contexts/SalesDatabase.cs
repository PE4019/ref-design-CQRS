using Edu.Infrastructure.Persistance.Entities;
using Edu.Infrastructure.Persistance.Interfaces;
using System.Data.Entity;

namespace Edu.Infrastructure.Persistance.Contexts
{
    public class SalesDatabase : DbContext, ISalesDatabase
    {
        public SalesDatabase()
            : base("SalesDatabase_Dev")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<PostalAddress> PostalAddresses { get; set; }

        public virtual DbSet<SalesOrder> SalesOrders { get; set; }

        public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
