using Despacho.API.Application.Interfaces;
using Despacho.API.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Despacho.API.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // TODO: registrar serviços do Application, mediadores, validadores e mapeamentos.
        return services;
    }

    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IHealthService, HealthService>();
        return services;
    }
}
