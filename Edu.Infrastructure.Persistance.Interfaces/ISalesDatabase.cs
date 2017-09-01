using Edu.Infrastructure.Persistance.Entities;
using System.Data.Entity;

namespace Edu.Infrastructure.Persistance.Interfaces
{
    public interface ISalesDatabase
    {
        DbSet<Customer> Customers { get; set; }

        DbSet<PostalAddress> PostalAddresses { get; set; }

        DbSet<SalesOrder> SalesOrders { get; set; }

        DbSet<SalesOrderItem> SalesOrderItems { get; set; }

        int SaveChanges();
    }
}
