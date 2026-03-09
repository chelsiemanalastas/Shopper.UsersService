using Microsoft.Extensions.DependencyInjection;
using Shopper.Application.Users;

namespace Shopper.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

        services.AddScoped<IUserContext, UserContext>();

        return services;
    }
}
