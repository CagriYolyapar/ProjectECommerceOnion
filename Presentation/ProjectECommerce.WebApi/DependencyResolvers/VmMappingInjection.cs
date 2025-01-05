using Project.APPLICATION.Mappings;
using ProjectECommerce.WebApi.Mappings;

namespace ProjectECommerce.WebApi.DependencyResolvers
{
    public static class VmMappingInjection
    {
        public static void AddVmMapperInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(VMMapProfile));
        }
    }
}
