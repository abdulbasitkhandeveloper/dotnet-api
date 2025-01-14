using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext // Corrected: Added 'class' and ':' for inheritance
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) // Corrected: Added 'base' keyword and specified type
        {
        }

        public DbSet<Product> Products { get; set; } // Corrected: Moved this line inside the class
    }
}