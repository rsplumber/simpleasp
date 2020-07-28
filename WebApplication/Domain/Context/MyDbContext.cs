using Microsoft.EntityFrameworkCore;
using WebApplication.Domain.Product.Model;

namespace WebApplication.Domain.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductEntityConfiguration());
        }
    }
}