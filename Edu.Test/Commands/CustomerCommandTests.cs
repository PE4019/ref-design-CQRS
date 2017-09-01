using Edu.Domain.Core.CommandHandlers.Customer;
using Edu.Domain.Core.Commands.Customer;
using Edu.Domain.Core.Model.Customer;
using Edu.Infrastructure.Persistance.Repositories;
using Edu.Test.Data.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Edu.Test.Commands
{
    [TestClass]
    public class CustomerCommandTests
    {
        private SalesMockDatabase database;

        [TestInitialize]
        public void InitializeMockDatabase()
        {
            this.database = SalesMockDatabaseInitializer.InitializeEmptyDatabase();
        }

        [TestMethod]
        public void CreateCustomer()
        {
            // Create repository using mock database
            CustomerRepository repo = new CustomerRepository(this.database);

            // Create command
            Address deliveryAddress = new Address()
            {
                StreetAddress = "Hemvärnsvägen 15",
                PostalAddress = new PostalAddress()
                {
                    PostCode = "31146",
                    City = "Falkenberg"
                }
            };
            CreateCustomerCommand command = new CreateCustomerCommand("Peter", "Eckersand", deliveryAddress);

            // Create command handler
            CreateCustomerCommandHandler commandHandler = new CreateCustomerCommandHandler(repo);

            // Execute command
            commandHandler.Execute(command);

            // Assert
            var dbCustomers = this.database.Customers.ToList();
            Assert.IsTrue(this.database.Customers.ToList().Count() == 1);

            var dbCustomer = dbCustomers.FirstOrDefault(c => c.FirstName == "Peter" && c.LastName == "Eckersand");
            Assert.IsNotNull(dbCustomer);
        }
    }
}
