using Shopper.API.Extensions;
using Shopper.API.Middlewares;
using Shopper.Application;
using Shopper.Infrastructure;
using Shopper.Infrastructure.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.AddPresentation();

var services = builder.Services;

// Add services to the container.
services.AddControllers();
services.AddApplication();
services.AddInfrastructure(builder.Configuration);

var app = builder.Build();
// Configure HTTP request pipeline.

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Map identity endpoints
app.MapGroup("api/identity")
    .WithTags("Identity")
    .MapIdentityApi<ApplicationUser>();

app.UseAuthorization();

app.MapControllers();

app.Run();
