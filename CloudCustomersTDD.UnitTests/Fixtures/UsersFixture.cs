using CloudCustomersTDD.API.Models;
using System.Collections.Generic;

namespace CloudCustomersTDD.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User
                {
                    Id = 1,
                    Name = "Marco",
                    Address = new Address()
                    {
                        Street = "Playas de Tijuana",
                        City = "Mexico",
                        ZipCode = 11111
                    },
                    Email = "marco@marco.com"
                },
                new User
                {
                    Id = 2,
                    Name = "Jose",
                    Address = new Address()
                    {
                        Street = "Playas de Tijuana",
                        City = "Mexico",
                        ZipCode = 11111
                    },
                    Email = "marco@marco.com"
                }
                ,
                new User
                {
                    Id = 3,
                    Name = "Hector",
                    Address = new Address()
                    {
                        Street = "Playas de Tijuana",
                        City = "Mexico",
                        ZipCode = 11111
                    },
                    Email = "marco@marco.com"
                }
            };
    }
}