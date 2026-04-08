using Despacho.API.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Despacho.API.Api.Controllers;

[ApiController]
[Route("despachos")]
public class DespachosController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<DespachoResponse> Create(DespachoCreateRequest request)
    {
        // TODO: registrar despacho único
        return NoContent();
    }

    [HttpPost("lote")]
    [ProducesResponseType(StatusCodes.Status207MultiStatus)]
    public ActionResult<DespachoLoteResponse> CreateBatch(DespachoLoteRequest request)
    {
        // TODO: registrar lote de despachos
        return NoContent();
    }

    [HttpGet]
    public ActionResult<PagedResponse<DespachoResponse>> GetAll([FromQuery] DespachoQueryRequest query)
    {
        // TODO: listar despachos com filtros
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public ActionResult<DespachoDeleteResponse> Delete(Guid id, [FromBody] DeleteDespachoRequest request)
    {
        // TODO: inativar despacho e registrar evento
        return NoContent();
    }
}
