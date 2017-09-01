using Edu.Application.QueryModel.Services.Customers;
using Edu.Application.QueryModel.ViewModels.Customers;
using Edu.Test.Data.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Edu.Test.QueryModel
{
    [TestClass]
    public class CustomerQueryTests
    {
        private SalesMockDatabase database;

        [TestInitialize]
        public void InitializeMockDatabase()
        {
            this.database = SalesMockDatabaseInitializer.InitializeEmptyDatabase();
        }

        [TestMethod]
        public void GetIndexList()
        {
            // Init data
            this.database = SalesMockDatabaseInitializer.AddCustomerWithPostalAddress(this.database);
            SalesMockQueryModel queryModel = new SalesMockQueryModel(this.database);

            // Query service
            CustomerServices service = new CustomerServices(queryModel);
            CustomerIndexVM viewModel = service.GetIndexList();

            // Assert
            var dbCustomers = this.database.Customers.ToList();
            Assert.IsTrue(dbCustomers.Count == 1);

            var dbCustomer = viewModel.Customers.FirstOrDefault(c => c.FirstName == "Peter" && c.LastName == "Eckersand");
            Assert.IsNotNull(dbCustomer);
        }
    }
}
