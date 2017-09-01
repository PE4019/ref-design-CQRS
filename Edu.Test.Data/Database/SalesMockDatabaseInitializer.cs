using Edu.Infrastructure.Persistance.Entities;
using System;
using System.Collections.Generic;

namespace Edu.Test.Data.Database
{
    public class SalesMockDatabaseInitializer
    {
        public static SalesMockDatabase InitializeEmptyDatabase()
        {
            return new SalesMockDatabase();
        }

        public static SalesMockDatabase AddPostalAddresses(SalesMockDatabase database)
        {
            PostalAddress pa1 = new PostalAddress()
            {
                PostalAddressID = 1,
                PostCode = "31146",
                City = "Falkenberg"
            };

            database.PostalAddresses.Add(pa1);
            database.SaveChanges();
            return database;
        }

        public static SalesMockDatabase AddCustomerWithPostalAddress(SalesMockDatabase database)
        {
            PostalAddress pa1 = new PostalAddress()
            {
                PostalAddressID = 1,
                PostCode = "31146",
                City = "Falkenberg"
            };

            Customer c1 = new Customer()
            {
                CustomerID = 1,
                FirstName = "Peter",
                LastName = "Eckersand",
                StreetAddress = "Hemvärnsvägen 15",
                PostalAddress = pa1
            };

            database.PostalAddresses.Add(pa1);
            database.Customers.Add(c1);
            database.SaveChanges();
            return database;
        }

        public static SalesMockDatabase AddSalesOrdersWithItems(SalesMockDatabase database)
        {
            SalesOrder o1 = new SalesOrder()
            {
                SalesOrderID = 1,
                OrderDate = Convert.ToDateTime("2017-03-12"),
            };

            SalesOrderItem oi1 = new SalesOrderItem()
            {
                SalesOrderItemID = 1,
                Name = "Ball",
                Price = 50M,
                SalesOrder = o1
            };

            SalesOrderItem oi2 = new SalesOrderItem()
            {
                SalesOrderItemID = 2,
                Name = "Hat",
                Price = 120M,
                SalesOrder = o1
            };

            o1.SalesOrderItems = new List<SalesOrderItem>() { oi1, oi2 };

            SalesOrder o2 = new SalesOrder()
            {
                SalesOrderID = 2,
                OrderDate = Convert.ToDateTime("2017-04-18"),
            };

            SalesOrderItem oi3 = new SalesOrderItem()
            {
                SalesOrderItemID = 3,
                Name = "Pen",
                Price = 5M,
                SalesOrder = o2
            };

            SalesOrderItem oi4 = new SalesOrderItem()
            {
                SalesOrderItemID = 4,
                Name = "Bike",
                Price = 1000M,
                SalesOrder = o2
            };

            o2.SalesOrderItems = new List<SalesOrderItem>() { oi3, oi4 };

            database.SalesOrders.Add(o1);
            database.SalesOrders.Add(o2);
            database.SalesOrderItems.Add(oi1);
            database.SalesOrderItems.Add(oi2);
            database.SalesOrderItems.Add(oi3);
            database.SalesOrderItems.Add(oi4);
            database.SaveChanges();
            return database;
        }
    }
}
