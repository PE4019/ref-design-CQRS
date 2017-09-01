using Edu.Infrastructure.Persistance.Entities;
using System.Collections.Generic;

namespace Edu.Application.QueryModel.ViewModels.SalesOrderViewModels
{
    public class SalesOrderWithItemsVM
    {
        public SalesOrderWithItemsVM()
        {
            this.SalesOrderItems = new List<SalesOrderItem>();
        }

        public SalesOrder SalesOrder { get; set; }

        public decimal OrderValue { get; set; }

        public IEnumerable<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
