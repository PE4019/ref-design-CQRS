using Edu.Infrastructure.Persistance.Contexts;
using Edu.Infrastructure.Persistance.Interfaces;
using Edu.Infrastructure.Persistance.Queries;
using Edu.Web.Infrastructure;
using Edu.Web.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edu.Web.App_Start
{
    public static class IocConfigurator
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            RegisterServices(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<ISalesDatabase, SalesDatabase>();
            container.RegisterType<IQueryModel, SalesDatabaseQueryModel>();
        }
    }
}