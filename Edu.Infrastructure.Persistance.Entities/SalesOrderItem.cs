using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Infrastructure.Persistance.Entities
{
    public class SalesOrderItem
    {
        public int SalesOrderItemID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        // Each SalesOrderItem belongs to a SalesOrder
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
