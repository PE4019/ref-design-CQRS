//using Edu.Application.QueryModel.Services.SalesOrderServices;
//using Edu.Application.QueryModel.ViewModels.SalesOrderViewModels;
//using Edu.Test.Data.Database;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Edu.Test
//{
//    [TestClass]
//    public class QueryModelTests
//    {
//        private SalesMockDatabase database;

//        [TestInitialize]
//        public void InitializeMockDatabase()
//        {
//            this.database = SalesMockDatabaseInitializer.InitializeEmptyDatabase();
//        }

//        [TestMethod]
//        public void GetSalesOrderWithItems()
//        {
//            // Add sales orders with items to database
//            this.database = SalesMockDatabaseInitializer.AddSalesOrdersWithItems(this.database);

//            SalesMockQueryModel queryModel = new SalesMockQueryModel(this.database);
//            SalesOrderServices queryService = new SalesOrderServices(queryModel);
//            SalesOrderWithItemsVM model = queryService.GetSalesOrderWithItems(1);
//        }

//        [TestMethod]
//        public void GetRecentSalesOrders()
//        {
//            // Add sales orders with items to database
//            this.database = SalesMockDatabaseInitializer.AddSalesOrdersWithItems(this.database);

//            SalesMockQueryModel queryModel = new SalesMockQueryModel(this.database);
//            SalesOrderServices queryService = new SalesOrderServices(queryModel);
//            RecentSalesOrdersVM model = queryService.GetRecentSalesOrders(5);
//        }
//    }
//}
