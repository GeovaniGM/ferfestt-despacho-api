using Despacho.API.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Despacho.API.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public ActionResult<LoginResponse> Login(LoginRequest request)
    {
        // TODO: autenticar usuário e retornar token JWT
        return NoContent();
    }
}
