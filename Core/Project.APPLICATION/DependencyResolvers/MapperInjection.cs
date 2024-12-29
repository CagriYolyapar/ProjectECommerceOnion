using Microsoft.Extensions.DependencyInjection;
using Project.APPLICATION.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.APPLICATION.DependencyResolvers
{
    public static class MapperInjection
    {
        public static void AddMapperInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapProfile));
        }
    }

    //ToDo: Middleware'de bu Injection cagrılacak
}
