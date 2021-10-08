using EKart.App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKart.App.Data
{
    public class EKartDbContext: DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order {  get; set; }
        public DbSet<ProductOrders> ProductOrders { get; set; }
        public DbSet<Product> Product { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= EPETER02;initial catalog=EKart;Integrated Security=True;ConnectRetryCount=0");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
           
            
        //}

    }
}
