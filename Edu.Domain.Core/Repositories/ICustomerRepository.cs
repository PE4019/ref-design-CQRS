using Edu.Domain.Core.Model.Customer;
using Edu.Domain.Interfaces;

namespace Edu.Domain.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        // Query methods

        // Command methods

        // Transactional
        void Commit();
    }
}
