using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagement.Data.Model;

namespace OrderManagement.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .Build();
                optionsBuilder.UseInMemoryDatabase("TestInMemory");
            }
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Article> Article { get; set; }

        public DbSet<ArticleGroup> ArticleGroup { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Position> Position { get; set; }
    }
}
