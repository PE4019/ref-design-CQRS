using Edu.Domain.Core.Commands.Customer;
using Edu.Domain.Core.Repositories;
using Edu.Domain.Interfaces;
using System;

namespace Edu.Domain.Core.CommandHandlers.Customer
{
    public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand>
    {
        private ICustomerRepository repository;

        public CreateCustomerCommandHandler(ICustomerRepository repository)
        {
            this.repository = repository;
        }


        public void Execute(CreateCustomerCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }

            if (this.repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            // Create customer aggregate
            Model.Customer.Customer aggregate = new Model.Customer.Customer();
            aggregate.ID = command.ID;
            aggregate.FirstName = command.FirstName;
            aggregate.LastName = command.LastName;
            aggregate.DeliveryAddress = command.DeliveryAddress;

            // Save new customer
            this.repository.Save(aggregate);
            this.repository.Commit();
        }
    }
}
