using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using Smartive.Core.Database.Repositories;

namespace OrderManagement.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCoreLogic(IServiceCollection services)
        {
            services.AddScoped<IDataOperations, DataOperations>();
            services.AddScoped<EfCrudRepository<Article>>();
            services.AddScoped<EfCrudRepository<ArticleGroup>>();
            services.AddScoped<EfCrudRepository<Customer>>();
            services.AddScoped<EfCrudRepository<Order>>();
            services.AddScoped<EfCrudRepository<Position>>();
            services.AddTransient<DbContext, DataContext>();
            return services;
        }
    }
}
