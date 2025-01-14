using System;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string PictureUrl { get; set; }
        public required string Type { get; set; }
        public required string Brand { get; set; }
    }
}