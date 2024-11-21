using Microsoft.EntityFrameworkCore;
using ProductService.Models;
using System.Collections.Generic;

namespace ProductService.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        // Use null! to tell the compiler that the property will be initialized by EF at runtime and it won't be null
        public DbSet<Product> Products { get; set; } = null!; 
    }
}
