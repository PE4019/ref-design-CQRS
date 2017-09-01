using Edu.Application.QueryModel.ViewModels.SalesOrderViewModels;
using Edu.Infrastructure.Persistance.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace Edu.Application.QueryModel.Services.SalesOrderServices
{
    /// <summary>
    /// Implements use cases for SalesOrders.
    /// </summary>
    public class SalesOrderServices
    {
        public SalesOrderServices(IQueryModel queryModel)
        {
            this.QueryModel = queryModel;
        }

        public IQueryModel QueryModel { get; private set; }

        public SalesOrderWithItemsVM GetSalesOrderWithItems(int id)
        {
            // Get SalesOrder by id and include order items
            var salesOrder = this.QueryModel.SalesOrders
                .Include(o => o.SalesOrderItems)
                .Where(o => o.SalesOrderID == id)
                .FirstOrDefault();

            if (salesOrder == null)
            {
                return null;
            }

            // Create VM
            SalesOrderWithItemsVM viewModel = new SalesOrderWithItemsVM();
            viewModel.SalesOrder = salesOrder;
            viewModel.OrderValue = salesOrder.SalesOrderItems.Sum(o => o.Price);
            viewModel.SalesOrderItems = salesOrder.SalesOrderItems.ToList();

            return viewModel;
        }

        public RecentSalesOrdersVM GetRecentSalesOrders(int nrOrders)
        {
            // Get SalesOrders sorted by order date
            var query = this.QueryModel.SalesOrders
                .OrderByDescending(o => o.OrderDate)
                .Take(nrOrders);

            // Create VM
            RecentSalesOrdersVM viewModel = new RecentSalesOrdersVM(nrOrders);
            viewModel.RecentSalesOrders = query.ToList();

            return viewModel;
        }
    }
}
