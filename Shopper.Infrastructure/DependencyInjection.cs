using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shopper.Infrastructure.Persistence;

namespace Shopper.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("UsersDb");
        services.AddDbContext<UsersDbContext>(options =>
            options.UseSqlServer(connectionString).EnableSensitiveDataLogging()
        );

        return services;
    }
}
