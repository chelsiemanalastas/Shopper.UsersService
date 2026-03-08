using Microsoft.Extensions.DependencyInjection;

namespace Shopper.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
