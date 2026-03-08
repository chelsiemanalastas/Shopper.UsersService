using Shopper.API.Middlewares;
using Shopper.Application;
using Shopper.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Add services to the container.
services.AddControllers();
services.AddApplication();
services.AddInfrastructure(builder.Configuration);

var app = builder.Build();
// Configure HTTP request pipeline.

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
