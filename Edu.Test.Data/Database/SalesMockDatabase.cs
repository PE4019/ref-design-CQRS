using Edu.Infrastructure.Persistance.Entities;
using Edu.Infrastructure.Persistance.Interfaces;
using System.Data.Entity;

namespace Edu.Test.Data.Database
{
    public class SalesMockDatabase : ISalesDatabase
    {
        public SalesMockDatabase()
        {
            this.Customers = new TestDbSet<Customer>();
            this.PostalAddresses = new TestDbSet<PostalAddress>();
            this.SalesOrders = new TestDbSet<SalesOrder>();
            this.SalesOrderItems = new TestDbSet<SalesOrderItem>();
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<PostalAddress> PostalAddresses { get; set; }

        public DbSet<SalesOrder> SalesOrders { get; set; }

        public DbSet<SalesOrderItem> SalesOrderItems { get; set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
