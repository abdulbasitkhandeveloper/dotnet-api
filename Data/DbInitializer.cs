using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DbInitializer
    {
         public static void initDb(WebApplication app)
         {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<StoreContext>()
                ?? throw new InvalidOperationException("Fail to retrieve store context");

                Console.WriteLine("Seeding data...");
            SeedData(context);
            Console.WriteLine("Data seeding completed.");
         }

        private static void SeedData(StoreContext context)
        {
            context.Database.Migrate();
            
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
            new Product { Id = 1, Name = "Samsung Galaxy S23", Description = "Latest smartphone with advanced features", Price = 79999, PictureUrl = "http://example.com/samsung.jpg", Type = "Electronics", Brand = "Samsung", QuantityStock = 100 },
            new Product { Id = 2, Name = "Sony WH-1000XM5", Description = "Noise-cancelling wireless headphones", Price = 29999, PictureUrl = "http://example.com/sony_headphones.jpg", Type = "Electronics", Brand = "Sony", QuantityStock = 50 },
            new Product { Id = 3, Name = "Adidas Ultraboost", Description = "Comfortable running shoes for daily use", Price = 14999, PictureUrl = "http://example.com/adidas.jpg", Type = "Clothing", Brand = "Adidas", QuantityStock = 200 },
            new Product { Id = 4, Name = "Dell XPS 15", Description = "High-performance laptop with a sleek design", Price = 179999, PictureUrl = "http://example.com/dell.jpg", Type = "Electronics", Brand = "Dell", QuantityStock = 30 },
            new Product { Id = 5, Name = "Apple MacBook Air", Description = "Lightweight and powerful laptop", Price = 99999, PictureUrl = "http://example.com/macbook.jpg", Type = "Electronics", Brand = "Apple", QuantityStock = 25 },
            new Product { Id = 6, Name = "Nike Air Max", Description = "Stylish sneakers for casual wear", Price = 12999, PictureUrl = "http://example.com/nike.jpg", Type = "Clothing", Brand = "Nike", QuantityStock = 150 },
            new Product { Id = 7, Name = "Kindle Paperwhite", Description = "E-book reader with a glare-free screen", Price = 15999, PictureUrl = "http://example.com/kindle.jpg", Type = "Books", Brand = "Amazon", QuantityStock = 80 },
            new Product { Id = 8, Name = "Logitech MX Master 3", Description = "Ergonomic wireless mouse for productivity", Price = 9999, PictureUrl = "http://example.com/logitech_mouse.jpg", Type = "Electronics", Brand = "Logitech", QuantityStock = 70 },
            new Product { Id = 9, Name = "Herman Miller Chair", Description = "Ergonomic office chair for comfort", Price = 79999, PictureUrl = "http://example.com/herman_miller.jpg", Type = "Furniture", Brand = "Herman Miller", QuantityStock = 20 },
            new Product { Id = 10, Name = "Dyson V15 Vacuum", Description = "Powerful cordless vacuum cleaner", Price = 59999, PictureUrl = "http://example.com/dyson.jpg", Type = "Home Appliances", Brand = "Dyson", QuantityStock = 40 },
            new Product { Id = 11, Name = "Canon EOS R6", Description = "Professional mirrorless camera", Price = 219999, PictureUrl = "http://example.com/canon.jpg", Type = "Electronics", Brand = "Canon", QuantityStock = 15 },
            new Product { Id = 12, Name = "Lego Technic Bugatti", Description = "Advanced building set for car enthusiasts", Price = 25999, PictureUrl = "http://example.com/lego.jpg", Type = "Toys", Brand = "Lego", QuantityStock = 100 },
            new Product { Id = 13, Name = "Apple Watch Series 8", Description = "Smartwatch with health tracking features", Price = 35999, PictureUrl = "http://example.com/apple_watch.jpg", Type = "Electronics", Brand = "Apple", QuantityStock = 60 },
            new Product { Id = 14, Name = "Samsung Smart TV 55\"", Description = "4K Ultra HD Smart TV with vibrant colors", Price = 79999, PictureUrl = "http://example.com/samsung_tv.jpg", Type = "Electronics", Brand = "Samsung", QuantityStock = 35 },
            new Product { Id = 15, Name = "HP LaserJet Pro", Description = "Efficient laser printer for office use", Price = 19999, PictureUrl = "http://example.com/hp_printer.jpg", Type = "Electronics", Brand = "HP", QuantityStock = 50 },
            new Product { Id = 16, Name = "Columbia Hiking Jacket", Description = "Waterproof and durable outdoor jacket", Price = 10999, PictureUrl = "http://example.com/columbia.jpg", Type = "Clothing", Brand = "Columbia", QuantityStock = 120 },
            new Product { Id = 17, Name = "Instant Pot Duo", Description = "Multi-functional electric pressure cooker", Price = 11999, PictureUrl = "http://example.com/instant_pot.jpg", Type = "Home Appliances", Brand = "Instant Pot", QuantityStock = 85 },
            new Product { Id = 18, Name = "Sony PlayStation 5", Description = "Next-generation gaming console", Price = 49999, PictureUrl = "http://example.com/ps5.jpg", Type = "Electronics", Brand = "Sony", QuantityStock = 10 },
            new Product { Id = 19, Name = "Casio G-Shock Watch", Description = "Durable and stylish digital watch", Price = 8999, PictureUrl = "http://example.com/gshock.jpg", Type = "Accessories", Brand = "Casio", QuantityStock = 200 },
            new Product { Id = 20, Name = "Blue Yeti Microphone", Description = "Professional USB microphone for streaming", Price = 12999, PictureUrl = "http://example.com/blue_yeti.jpg", Type = "Electronics", Brand = "Blue", QuantityStock = 50 }
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }
    } 
}
