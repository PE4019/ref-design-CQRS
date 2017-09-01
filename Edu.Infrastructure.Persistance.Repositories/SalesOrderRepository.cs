using Edu.Domain.Core.Repositories;
using Edu.Infrastructure.Persistance.Interfaces;
using System;
using System.Linq;
using DModel = Edu.Domain.Core.Model.SalesOrder;

namespace Edu.Infrastructure.Persistance.Repositories
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        protected ISalesDatabase database;

        public SalesOrderRepository(ISalesDatabase database)
        {
            this.database = database;
        }

        public DModel.SalesOrder GetByID(int id)
        {
            var entity = this.database.SalesOrders.FirstOrDefault(o => o.SalesOrderID == id);

            var builder = new DModel.SalesOrderBuilder();
            var model = builder.Result;
            model.OrderDate = entity.OrderDate;
            return model;
        }

        public void Save(DModel.SalesOrder aggregate)
        {
            throw new NotImplementedException();
        }

        public void Delete(DModel.SalesOrder aggregate)
        {
            // "Delete" by setting a property "deleted" to true in database
            throw new NotImplementedException();
        }

        public void Commit()
        {
            this.database.SaveChanges();
        }
    }
}

