using EHR_API.Repositories.Contracts;
using EHR_API.Repositories.Implementation;

namespace EHR_API.Extensions.Utility
{
    /*
          - An extension method:
              * it is inherently a static method. 
              * What makes it different from other static methods is that it accepts /this\ as the first parameter 
                      ** /this\ represents the data type of the object which will be using that extension method.
              * it must be defined inside a static class     
              * it extends the behavior of a type in .NET
      */
    public static class ServiceExtensions
    {
        /*
            - CORS (Cross-Origin Resource Sharing): 
                * it is a mechanism to give or restrict access rights to applications from different domains.
                * domains -> https://www.indeed.com/career-advice/career-development/domains-types
         */
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => {
                    /* 
                     * Instead of the AllowAnyOrigin() method, we can use the WithOrigins("https://example.com")
                     * Instead of the AllowAnyHeader() method, we can use the WithHeaders("accept", "content-type") method
                     * Instead of the AllowAnyMethod(), we can use WithMethods("POST", "GET")
                     */
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
        }

        /*
            - IIS integration help us with the deployment to IIS
         */
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        } 
        public static void ConfigureInterfaces(this IServiceCollection services)
        {
            services.AddScoped<IGovernorateRepository, GovernorateRepository>();
            services.AddScoped<IHealthFacilityRepository, HealthFacilityRepository>();
        }

    }
}
