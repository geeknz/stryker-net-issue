using Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace MediatorStryker;

internal static class StartupExtensions
{
    internal static WebApplication Configure(this WebApplication app, IWebHostEnvironment env)
    {
        return app;
    }

    internal static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        var services = builder.Services;
        services.AddCommonServices();

        return builder;
    }
}