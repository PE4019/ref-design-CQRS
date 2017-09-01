using Edu.Domain.Core.Model.Customer;
using Edu.Domain.Interfaces;

namespace Edu.Domain.Core.Commands.Customer
{
    public class CreateCustomerCommand : Command
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Address DeliveryAddress { get; private set; }

        public CreateCustomerCommand(string firstName, string lastName, Address deliveryAddress)
            : base(0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DeliveryAddress = deliveryAddress;
        }
    }
}
