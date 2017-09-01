using Edu.Domain.Interfaces;
using System;

namespace Edu.Domain.Core.Model.SalesOrder
{
    public class SalesOrder : IAggregateRoot
    {
        internal SalesOrder()
        {
            this.ID = 0;
        }

        public int ID { get; private set; }

        public bool IsSaveable
        {
            get
            {
                return this.Validate();
            }
        }

        public DateTime OrderDate { get; set; }

        private bool Validate()
        {
            return true;
        }
    }
}
