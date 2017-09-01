using Edu.Domain.Core.Repositories;
using Edu.Infrastructure.Persistance.Interfaces;
using System;
using System.Linq;
using DModel = Edu.Domain.Core.Model.Customer;
using Entity = Edu.Infrastructure.Persistance.Entities;

namespace Edu.Infrastructure.Persistance.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        protected ISalesDatabase database;

        public CustomerRepository(ISalesDatabase database)
        {
            this.database = database;
        }

        public DModel.Customer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(DModel.Customer aggregate)
        {
            // Check if Customer entity exists in database
            var customer = this.database.Customers.Where(c => c.CustomerID == aggregate.ID).FirstOrDefault();

            if (customer == null)
            {
                // Customer entity doesn't exists so insert new

                // Check if PostalAddress entity exists in database
                var postalAddress = this.database.PostalAddresses
                    .Where(a => (a.PostCode == aggregate.DeliveryAddress.PostalAddress.PostCode)
                    && (a.City == aggregate.DeliveryAddress.PostalAddress.City)).FirstOrDefault();

                if (postalAddress == null)
                {
                    // PostalAddress entity doesn't exists so insert new
                    postalAddress = new Entities.PostalAddress()
                    {
                        PostalAddressID = 0, // new entity
                        PostCode = aggregate.DeliveryAddress.PostalAddress.PostCode,
                        City = aggregate.DeliveryAddress.PostalAddress.City
                    };

                    this.database.PostalAddresses.Add(postalAddress);
                }

                // Create new Customer entity and add PostalAddress to it
                customer = new Entities.Customer()
                {
                    CustomerID = aggregate.ID,
                    FirstName = aggregate.FirstName,
                    LastName = aggregate.LastName,
                    StreetAddress = aggregate.DeliveryAddress.StreetAddress,
                    PostalAddress = postalAddress
                };

                this.database.Customers.Add(customer);
            }
            else
            {
                // Update

            }
        }

        public void Delete(DModel.Customer aggregate)
        {
            // "Delete" by setting a property "deleted" to true in database
            throw new NotImplementedException();
        }

        public void Commit()
        {
            this.database.SaveChanges();
        }
    }
}

