using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagement.Data.Model;

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

             /* if (!optionsBuilder.IsConfigured)
              {
                  IConfigurationRoot configuration = new ConfigurationBuilder()
                     .Build();
                  optionsBuilder.UseInMemoryDatabase("TestInMemory");
              }*/


           // optionsBuilder.UseSqlServer("Data Source=DESKTOP-TC55N4H;Database=OrderManager; Trusted_Connection=True; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlConnectionString"));
          //  optionsBuilder.LogTo(Console.WriteLine);
        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Article> Article { get; set; }

        public DbSet<ArticleGroup> ArticleGroup { get; set; }

        public DbSet<ArticleGroupView> ArticleGroupView { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Position> Position { get; set; }
    }
}
