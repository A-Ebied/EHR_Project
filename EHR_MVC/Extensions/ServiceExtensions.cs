using EHR_MVC.Repositories.Contracts;
using EHR_MVC.Repositories.Implementation;

namespace EHR_API.Extensions
{
    public static class ServiceExtensions
    {
        
        public static void ConfigureInterfaces(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddHttpClient<IGovernorateService, GovernorateService>();
            services.AddScoped<IGovernorateService, GovernorateService>();

            services.AddHttpClient<IHealthFacilityService, HealthFacilityIService>();
            services.AddScoped<IHealthFacilityService, HealthFacilityIService>();

            services.AddHttpClient<IAuthenService, AuthenService>();
            services.AddScoped<IAuthenService, AuthenService>();
        }

    }
}
