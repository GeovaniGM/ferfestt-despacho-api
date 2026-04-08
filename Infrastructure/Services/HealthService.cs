using Despacho.API.Application.Interfaces;

namespace Despacho.API.Infrastructure.Services;

public class HealthService : IHealthService
{
    public string GetStatus() => "healthy";
}
