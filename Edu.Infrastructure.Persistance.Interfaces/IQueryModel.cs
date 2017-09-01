using Edu.Infrastructure.Persistance.Entities;
using System.Linq;

namespace Edu.Infrastructure.Persistance.Interfaces
{
    public interface IQueryModel
    {
        IQueryable<Customer> Customers { get; }

        IQueryable<PostalAddress> PostalAddresses { get; }

        IQueryable<SalesOrder> SalesOrders { get; }

        IQueryable<SalesOrderItem> SalesOrderItems { get; }
    }
}
