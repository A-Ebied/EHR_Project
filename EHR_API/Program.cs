using EHR_API.Entities;
using EHR_API.Extensions.Utility;
using EHR_API.Repositories.Contracts;
using EHR_API.Repositories.Implementation;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*-------------------*/
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"))
    );
builder.Services.ConfigureInterfaces();
builder.Services.AddAutoMapper(typeof(MappingConfig));


builder.Services.AddControllers(
    //option => { option.ReturnHttpNotAcceptable = true; }
    ).AddNewtonsoftJson(/*x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore*/)/*.AddXmlDataContractSerializerFormatters()*/;
/*-------------------*/

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
app.UseAuthorization();

app.MapControllers();

app.Run();
