using Edu.Application.QueryModel.Services.Customers;
using Edu.Domain.Core.Repositories;
using Edu.Infrastructure.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edu.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ISalesDatabase database;

        private IQueryModel queryModel;

        public CustomerController(ISalesDatabase database, IQueryModel queryModel)
        {
            this.database = database;
            this.queryModel = queryModel;
        }

        [HttpGet]
        public ActionResult Index()
        {
            CustomerServices queryService = new CustomerServices(this.queryModel);
            var model = queryService.GetIndexList();
            return this.View(model);
        }
    }
}