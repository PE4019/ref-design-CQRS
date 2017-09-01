using Edu.Domain.Interfaces;

namespace Edu.Domain.Core.Model.Customer
{
    public class Customer : IAggregateRoot
    {
        internal Customer()
        {
            this.ID = 0;
        }

        public int ID { get; set; }

        public bool IsSaveable
        {
            get
            {
                return this.Validate();
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public CustomerCategory Category
        {
            get
            {
                if (this.YearTotalOrderValue < 1000M)
                {
                    return CustomerCategory.Bronze;
                }
                else if (this.YearTotalOrderValue < 3000M)
                {
                    return CustomerCategory.Silver;
                }
                else
                {
                    return CustomerCategory.Gold;
                }
            }
        }

        public decimal YearTotalOrderValue { get; private set; }

        public Address DeliveryAddress { get; set; }

        private bool Validate()
        {
            return true;
        }
    }
}
