using System.Linq;
using Edu.Infrastructure.Persistance.Entities;
using Edu.Infrastructure.Persistance.Interfaces;

namespace Edu.Test.Data.Database
{
    public class SalesMockQueryModel : IQueryModel
    {
        private SalesMockDatabase database;

        public SalesMockQueryModel(SalesMockDatabase database)
        {
            this.database = database;
        }

        public IQueryable<Customer> Customers
        {
            get
            {
                return this.database.Customers.AsQueryable();
            }
        }

        public IQueryable<PostalAddress> PostalAddresses
        {
            get
            {
                return this.database.PostalAddresses.AsQueryable();
            }
        }

        public IQueryable<SalesOrder> SalesOrders
        {
            get
            {
                return this.database.SalesOrders.AsQueryable();
            }
        }

        public IQueryable<SalesOrderItem> SalesOrderItems
        {
            get
            {
                return this.database.SalesOrderItems.AsQueryable();
            }
        }
    }
}
