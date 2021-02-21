using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OrderManagement.Data.Context;

namespace OrderManagement
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {

        DataContext IDesignTimeDbContextFactory<DataContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DataContext>();
            var connectionString = configuration.GetConnectionString("SqlConnectionString");

            builder.UseSqlServer(connectionString, b => b.MigrationsAssembly("OrderManagement.Data"));

            return new DataContext(builder.Options);
        }
    }
}
