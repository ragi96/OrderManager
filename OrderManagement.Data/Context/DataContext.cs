using System;
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
            /* base.OnConfiguring(optionsBuilder);

             if (!optionsBuilder.IsConfigured)
             {
                 IConfigurationRoot configuration = new ConfigurationBuilder()
                    .Build();
                 optionsBuilder.UseInMemoryDatabase("TestInMemory");
             }*/
            optionsBuilder.UseSqlServer("Data Source=.\\symas;Database=OrderManagement; Trusted_Connection=True");
            /*var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("OrderManagement"));
            optionsBuilder.LogTo(Console.WriteLine);*/
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Article> Article { get; set; }

        public DbSet<ArticleGroup> ArticleGroup { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Position> Position { get; set; }
    }
}
