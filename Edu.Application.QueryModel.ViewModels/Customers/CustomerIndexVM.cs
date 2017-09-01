using Edu.Infrastructure.Persistance.Entities;
using System.Collections.Generic;

namespace Edu.Application.QueryModel.ViewModels.Customers
{
    public class CustomerIndexVM
    {
        public CustomerIndexVM()
        {
            this.Customers = new List<Customer>();
        }

        public List<Customer> Customers { get; set; }
    }
}
