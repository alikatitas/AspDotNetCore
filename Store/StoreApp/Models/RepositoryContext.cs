using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product(){ProductId=1,ProductName="Computer",Price=2_000},
                new Product(){ProductId=2,ProductName="Keyboard",Price=500},
                new Product(){ProductId=3,ProductName="Mouse",Price=250},
                new Product(){ProductId=4,ProductName="TV",Price=3_700}
                
            );
        }
    }
}