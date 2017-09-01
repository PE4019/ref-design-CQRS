//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Edu.Domain.Core.Commands.Customer;
//using Edu.Domain.Core.Model.Customer;
//using Edu.Domain.Core.CommandHandlers.Customer;
//using Edu.Infrastructure.Persistance.Repositories;
//using Edu.Test.Data.Database;

//namespace Edu.Test
//{
//    [TestClass]
//    public class CommandTests
//    {
//        private SalesMockDatabase database;

//        [TestInitialize]
//        public void InitializeMockDatabase()
//        {
//            this.database = SalesMockDatabaseInitializer.InitializeEmptyDatabase();
//        }

//        [TestMethod]
//        public void CreateCustomer()
//        {
//            // Create repository using mock database
//            CustomerRepository repo = new CustomerRepository(this.database);

//            // Create command
//            Address deliveryAddress = new Address()
//            {
//                StreetAddress = "Hemvärnsvägen 15",
//                PostalAddress = new PostalAddress()
//                {
//                    PostCode = "31146",
//                    City = "Falkenberg"
//                }
//            };
//            CreateCustomerCommand command = new CreateCustomerCommand("Peter", "Eckersand", deliveryAddress);

//            // Create command handler
//            CreateCustomerCommandHandler commandHandler = new CreateCustomerCommandHandler(repo);

//            // Execute command
//            commandHandler.Execute(command);
//        }

//        [TestMethod]
//        public void CreateCustomerWithExistingPostalAddress()
//        {
//            // Add postal address to database
//            this.database = SalesMockDatabaseInitializer.AddPostalAddresses(this.database);

//            // Create repository using mock database
//            CustomerRepository repo = new CustomerRepository(this.database);

//            // Create command
//            Address deliveryAddress = new Address()
//            {
//                StreetAddress = "Hemvärnsvägen 15",
//                PostalAddress = new PostalAddress()
//                {
//                    PostCode = "31146",
//                    City = "Falkenberg"
//                }
//            };
//            CreateCustomerCommand command = new CreateCustomerCommand("Peter", "Eckersand", deliveryAddress);

//            // Create command handler
//            CreateCustomerCommandHandler commandHandler = new CreateCustomerCommandHandler(repo);

//            // Execute command
//            commandHandler.Execute(command);
//        }
//    }
//}
