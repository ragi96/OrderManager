
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagement.Data.Model;
using System.IO;

namespace OrderManagement.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DataContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlConnectionString"));
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Article> Article { get; set; }

        public DbSet<ArticleGroup> ArticleGroup { get; set; }

        public DbSet<ArticleGroupView> ArticleGroupView { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Position> Position { get; set; }
    }
}
