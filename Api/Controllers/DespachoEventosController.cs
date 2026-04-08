using Despacho.API.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Despacho.API.Api.Controllers;

[ApiController]
[Route("despacho-eventos")]
public class DespachoEventosController : ControllerBase
{
    [HttpGet]
    public ActionResult<IReadOnlyList<DespachoEventoResponse>> GetAll([FromQuery] DespachoEventoQueryRequest query)
    {
        // TODO: listar eventos de despacho com filtros
        return NoContent();
    }
}
