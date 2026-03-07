using Shopper.API.Middlewares;
using Shopper.Core;
using Shopper.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Add services to the container.
services.AddInfrastructure();
services.AddCore();

// Add controllers
services.AddControllers();

var app = builder.Build();
// Configure HTTP request pipeline.

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
