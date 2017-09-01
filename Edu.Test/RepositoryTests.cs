//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Edu.Infrastructure.Persistance.Repositories;
//using Edu.Test.Data.Database;

//namespace Edu.Test
//{
//    [TestClass]
//    public class RepositoryTests
//    {
//        private SalesMockDatabase database;

//        [TestInitialize]
//        public void InitializeMockDatabase()
//        {
//            this.database = SalesMockDatabaseInitializer.InitializeEmptyDatabase();
//        }


//        [TestMethod]
//        public void TestRepo()
//        {
//            // Add sales orders with items to database
//            this.database = SalesMockDatabaseInitializer.AddSalesOrdersWithItems(this.database);

//            SalesOrderRepository repo = new SalesOrderRepository(this.database);
//            var order = repo.GetByID(1);
//        }
//    }
//}
