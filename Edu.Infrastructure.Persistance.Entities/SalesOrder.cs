using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Edu.Infrastructure.Persistance.Entities
{
    public class SalesOrder
    {
        [Key]
        public int SalesOrderID { get; set; }

        public DateTime OrderDate { get; set; }

        // Each SalesOrder has a collection of SalesOrderItems
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
