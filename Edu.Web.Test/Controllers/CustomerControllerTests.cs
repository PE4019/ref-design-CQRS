using Microsoft.VisualStudio.TestTools.UnitTesting;
using Edu.Web.Controllers;
using Edu.Test.Data.Database;
using System.Web.Mvc;

namespace Edu.Web.Test.Controllers
{
    [TestClass]
    public class CustomerControllerTests
    {
        private SalesMockDatabase database;

        [TestInitialize]
        public void InitializeMockDatabase()
        {
            this.database = SalesMockDatabaseInitializer.InitializeEmptyDatabase();

        }

        [TestMethod]
        public void Index()
        {
            this.database = SalesMockDatabaseInitializer.AddCustomerWithPostalAddress(this.database);
            SalesMockQueryModel queryModel = new SalesMockQueryModel(this.database);
            CustomerController controller = new CustomerController(this.database, queryModel);
            ViewResult result = controller.Index() as ViewResult;
            var model = result.Model;
        }
    }
}
