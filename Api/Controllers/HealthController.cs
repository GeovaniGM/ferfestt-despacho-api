using Despacho.API.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Despacho.API.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    private readonly IHealthService _healthService;

    public HealthController(IHealthService healthService)
    {
        _healthService = healthService;
    }

    [HttpGet]
    public IActionResult Get() => Ok(new { status = _healthService.GetStatus() });
}
