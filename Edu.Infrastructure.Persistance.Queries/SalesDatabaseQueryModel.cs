using Edu.Infrastructure.Persistance.Contexts;
using Edu.Infrastructure.Persistance.Entities;
using Edu.Infrastructure.Persistance.Interfaces;
using System.Linq;

namespace Edu.Infrastructure.Persistance.Queries
{
    public class SalesDatabaseQueryModel : IQueryModel
    {
        private SalesDatabase database;

        public SalesDatabaseQueryModel()
        {
            this.database = new SalesDatabase();
            this.Customers = this.database.Set<Customer>();
            this.PostalAddresses = this.database.Set<PostalAddress>();
            this.SalesOrders = this.database.Set<SalesOrder>();
            this.SalesOrderItems = this.database.Set<SalesOrderItem>();
        }
        public IQueryable<Customer> Customers { get; private set; }

        public IQueryable<PostalAddress> PostalAddresses { get; private set; }

        public IQueryable<SalesOrder> SalesOrders { get; private set; }

        public IQueryable<SalesOrderItem> SalesOrderItems { get; private set; }
    }
}
