using Edu.Infrastructure.Persistance.Entities;
using System.Collections.Generic;

namespace Edu.Application.QueryModel.ViewModels.SalesOrderViewModels
{
    public class RecentSalesOrdersVM
    {
        public RecentSalesOrdersVM(int nrOrders)
        {
            this.NrOrders = nrOrders;
            this.RecentSalesOrders = new List<SalesOrder>();
        }

        public int NrOrders { get; private set; }

        public IEnumerable<SalesOrder> RecentSalesOrders { get; set; }
    }
}
