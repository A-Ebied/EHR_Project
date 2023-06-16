using EHR_API.Entities;
using EHR_API.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*-------------------*/
/* 
 * adds the CorsPolicy service to the dependency injection container.
 * 
 * Cross-Origin Resource Sharing (CORS) is a security feature support to an application:
 *  - to specify which origins are allowed to access the resources on the server.
 *  - to specify which headers are allowed.
 *   - to specify which methods are allowed.
 */

builder.Services.ConfigureCors();

/* 
 * adds a database context to the dependency injection container
 *
 * The database context represents a session with the database, and is responsible for handling database connections, managing transactions, and providing access to the database tables and entities. 
 */
builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    });

builder.Services.ConfigureInterfacesAPI();
builder.Services.AddAutoMapper(typeof(MappingConfig));

// Registers services required by authentication services to enable the authentication middleware to process authentication requests.
builder.Services.AddAuthentication();

builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);
//builder.Services.AddResponseCaching();
builder.Services.AddControllersConfiguration();
builder.Services.AddScoped<DbInitializer>();

var emailConfig = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);
/*-------------------*/
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenConfiguration();

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
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, "wwwroot/files")),
    RequestPath = "/files"
});

app.UseCors("CorsPolicy");
SeedDatabase();
/*-------------------*/
//added to the pipeline to establish the identity of the user making the request
app.UseAuthentication();
/*-------------------*/

// checks whether the request is authorized based on the user's roles, claims, and policies
app.UseAuthorization();

//   a middleware which maps controller actions to HTTP requests
//  route HTTP requests to the appropriate controller action based on the URL and HTTP method of the request
app.MapControllers();

app.Run();

void SeedDatabase()
{
    using var scope = app.Services.CreateScope();
    var dbInitializer = scope.ServiceProvider.GetRequiredService<DbInitializer>();
    dbInitializer.Initialize();
}