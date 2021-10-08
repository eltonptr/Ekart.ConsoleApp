using EKart.App.Data;
using EKart.App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKart.App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //SaveCustomer();
            await GetCustomerDetails();

        }

        private async static Task GetCustomerDetails()
        {
            using EKartDbContext dbContext = new EKartDbContext();
            
            List<Customer> customers = await dbContext.Customer.Where(c => c.Address == "Z").ToListAsync();
            if (customers.Count > 0)
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Name: {customer.Name}");
                }
            }
            else
            {
                Console.WriteLine($"No Customer Found");
            }

            Customer newCustomer = dbContext.Customer.Where(c => c.Name.Equals("John")).FirstOrDefault();
            if (newCustomer is Customer)
            {
                Console.WriteLine($"Name: {newCustomer.Name}");
            }
            else
            {
                Console.WriteLine($"No Customer Found");
            }
        }

        private static void SaveCustomer()
        {
            using EKartDbContext dbContext = new EKartDbContext();
            Customer person1 = new Customer()
            {
                Name = "John",
                StreetName = "A",
                Address = "A",
                City = "C",
                Email = "E",
                Phone = "E"
            };
            dbContext.Customer.Add(person1);

            Customer person2 = new Customer()
            {
                Name = "Peter",
                StreetName = "A",
                Address = "A",
                City = "C",
                Email = "E",
                Phone = "E"
            };
            dbContext.Add(person2);
            dbContext.SaveChanges();
        }
    }
}
