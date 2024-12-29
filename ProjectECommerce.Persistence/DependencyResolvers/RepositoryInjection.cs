using Microsoft.Extensions.DependencyInjection;
using Project.Contract.RepositoryInterfaces;
using ProjectECommerce.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectECommerce.Persistence.DependencyResolvers
{
    public static class RepositoryInjection
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IAppUserRepository,AppUserRepository>();
            services.AddScoped<IAppUserProfileRepository, AppUserProfileRepository>();
        }
    }
}
