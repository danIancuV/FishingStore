using System;
using FishingStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace FishingStore.Data
{
    public class FishingStoreContext : DbContext
    {
        public FishingStoreContext(DbContextOptions<FishingStoreContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
