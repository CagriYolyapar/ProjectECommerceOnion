using Microsoft.Extensions.DependencyInjection;
using Project.APPLICATION.ServiceInterfaces;
using ProjectECommerce.InnerInfrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectECommerce.InnerInfrastructure.DependencyResolvers
{
    public static class ManagerServiceInjection
    {
        public static void AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppUserProfileManager, AppUserProfileManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IOrderDetailManager, OrderDetailManager>();  
        }
    }
}
