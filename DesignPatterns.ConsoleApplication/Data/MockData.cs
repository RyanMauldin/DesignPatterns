using System;
using System.Collections.Generic;
using DesignPatterns.Models;

namespace DesignPatterns.ConsoleApplication.Data
{
    public static class MockData
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                AccountNumber = "234252",
                FirstName = "Testin",
                MiddleName = "This",
                LastName = "Pattern",
                Email = "AGoogleZeros@bing.com",
                Company = "Poor Man's IOC, Inc.",
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "Ryan Mauldin",
                LastModifiedOn = DateTime.UtcNow,
                LastModifiedBy = "Ryan Mauldin"
            },
            new Customer
            {
                Id = 2,
                AccountNumber = "234254",
                FirstName = "Ryan",
                MiddleName = "Pattern",
                LastName = "Man",
                Email = "AGoogleZeros@testing123.com",
                Company = "Just made it up for reals, LLC",
                CreatedOn = DateTime.UtcNow,
                CreatedBy = "Ryan Mauldin",
                LastModifiedOn = DateTime.UtcNow,
                LastModifiedBy = "Ryan Mauldin"
            }
        };
    }
}
