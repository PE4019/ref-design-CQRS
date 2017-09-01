using Edu.Application.QueryModel.ViewModels.Customers;
using Edu.Infrastructure.Persistance.Entities;
using Edu.Infrastructure.Persistance.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Edu.Application.QueryModel.Services.Customers
{
    public class CustomerServices
    {
        private IQueryModel queryModel;

        public CustomerServices(IQueryModel queryModel)
        {
            this.queryModel = queryModel;
        }

        public CustomerIndexVM GetIndexList()
        {
            var list = this.queryModel.Customers.ToList();
            CustomerIndexVM viewModel = new CustomerIndexVM();
            viewModel.Customers = new List<Customer>(list);

            return viewModel;
        }
    }
}
