using EHR_API.Entities;
using EHR_API.Extensions;
using EHR_API.Repositories.Contracts;
using EHR_API.Repositories.Implementation;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*-------------------*/
builder.Services.ConfigureCors();
//builder.Services.ConfigureIISIntegration();

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"))
    );
builder.Services.ConfigureInterfaces();
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);
//builder.Services.AddApiVersioning( option =>
//   {
//       option.AssumeDefaultVersionWhenUnspecified = true;
//       option.DefaultApiVersion = new ApiVersion(1, 0);
//});
builder.Services.AddResponseCaching();
builder.Services.AddControllers(
    option => 
    {
        // option.ReturnHttpNotAcceptable = true;
        option.CacheProfiles.Add("DefCache",
            new CacheProfile
            {
                Duration = 10
            });
    }
    ).AddNewtonsoftJson(/*x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore*/)/*.AddXmlDataContractSerializerFormatters()*/;
/*-------------------*/

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
/*-------------------*/
// enables using static files for the request.
app.UseStaticFiles();
app.UseCors("CorsPolicy");
/*-------------------*/
app.UseAuthentication();
/*-------------------*/
app.UseAuthorization();

app.MapControllers();

app.Run();
