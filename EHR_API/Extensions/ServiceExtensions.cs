using EHR_API.Entities;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
using EHR_API.Repositories.Implementation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace EHR_API.Extensions
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
                options.AddPolicy("CorsPolicy", builder =>
                {
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
         
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }
        */

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<RegistrationData, IdentityRole>(
                o =>
                {
                    o.Password.RequireDigit = true;
                    o.Password.RequireLowercase = true;
                    o.Password.RequireUppercase = true;
                    o.Password.RequireNonAlphanumeric = true;
                    o.Password.RequiredLength = 5;
                    o.User.RequireUniqueEmail = true;
                }).AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }

        public static void ConfigureInterfaces(this IServiceCollection services)
        {
            //services.AddScoped<IGovernorateRepository, GovernorateRepository>();
            services.AddScoped<IAllergyRepository, AllergyRepository>();
            services.AddScoped<IAllergyDrugRepository, AllergyDrugRepository>();
            services.AddScoped<IMainRepository, MainRepository>();
        }

        /*
         * JSON Web Token (JWT) is a way for securely transmitting information between parties as a JSON object. 
         * JWTs can be signed using a secret (with the HMAC algorithm) or a public/private key pair using RSA or ECDSA.
         */

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration) 
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings.GetValue<string>("Secret");
            
            services.AddAuthentication(
                opt => 
                { 
                    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                 // it allows the app to perform authentication checks based on an incoming JWT token.
                }).AddJwtBearer(
                    options => 
                    {
                        // specify which aspects of the incoming JWTs to validate
                        options.TokenValidationParameters = new TokenValidationParameters 
                        {
                            ValidateIssuer = true, 
                            ValidateAudience = true, 
                            ValidateLifetime = true, 
                            ValidateIssuerSigningKey = true, 
                            ValidIssuer = jwtSettings["validIssuer"], 
                            ValidAudience = jwtSettings["validAudience"], 
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)) 
                        }; 
                    }); 
        }

        public static void AddControllersConfiguration(this IServiceCollection services)
        {
            services.AddControllers(
                option =>
                {
                    // option.ReturnHttpNotAcceptable = true;
                    option.CacheProfiles.Add("DefCache",
                        new CacheProfile
                        {
                            Duration = 10
                        });

                }
                ).AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)/*.AddXmlDataContractSerializerFormatters()*/;
        }

        public static void AddSwaggerGenConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(
                options =>
                {
                    options.AddSecurityDefinition(
                        "Bearer", new OpenApiSecurityScheme()
                        {
                            Description = """
                            Enter 'Bearer ' then your token, ex: Bearer 1234
                            """,
                            Name = "Authorization",
                            In = ParameterLocation.Header,
                            Scheme = "Bearer"
                        });

                    options.AddSecurityRequirement(
                        new OpenApiSecurityRequirement()
                        {
                            {
                                new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "Bearer"
                                    },
                                    Scheme = "oath2",
                                    Name = "Bearer",
                                    In = ParameterLocation.Header
                                },
                                new List<string>()
                            }
                        });
                });
        }


    }
}
