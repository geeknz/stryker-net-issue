using Microsoft.Extensions.DependencyInjection;

namespace Common;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCommonServices(this IServiceCollection services)
    {
        services.AddMediator(s => s.ServiceLifetime = ServiceLifetime.Scoped);

        return services;
    }
}