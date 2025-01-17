using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext // Fixed class definition
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) // Proper constructor
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}