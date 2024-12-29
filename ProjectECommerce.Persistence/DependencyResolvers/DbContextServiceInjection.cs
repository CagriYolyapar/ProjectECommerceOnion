﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectECommerce.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectECommerce.Persistence.DependencyResolvers
{
    public static class DbContextServiceInjection
    {
        public static void AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();

            services.AddDbContext<MyContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("CagriConnection")).UseLazyLoadingProxies());
        }
    }
}
