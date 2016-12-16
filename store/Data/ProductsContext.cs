using Microsoft.EntityFrameworkCore;
using store.Models;

namespace store 
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=mysql5015.smarterasp.net;database=db_9f2d65_core;uid=9f2d65_core;pwd=qsc45plm87;");
    }
}