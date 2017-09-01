using Edu.Domain.Core.Model.SalesOrder;
using Edu.Domain.Interfaces;

namespace Edu.Domain.Core.Repositories
{
    public interface ISalesOrderRepository : IRepository<SalesOrder, int>
    {
        // Query methods

        // Command methods

        // Transactional
        void Commit();
    }
}
