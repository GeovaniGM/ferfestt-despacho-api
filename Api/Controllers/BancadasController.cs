using Despacho.API.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Despacho.API.Api.Controllers;

[ApiController]
[Route("bancadas")]
public class BancadasController : ControllerBase
{
    [HttpGet("{id:guid}")]
    public ActionResult<BancadaResponse> GetById(Guid id)
    {
        // TODO: buscar bancada por id
        return NoContent();
    }

    [HttpGet]
    public ActionResult<IReadOnlyList<BancadaResponse>> GetAll()
    {
        // TODO: listar bancadas
        return NoContent();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<BancadaResponse> Create(BancadaCreateRequest request)
    {
        // TODO: criar nova bancada
        return NoContent();
    }

    [HttpPatch("{id:guid}")]
    public ActionResult<BancadaResponse> Update(Guid id, BancadaUpdateRequest request)
    {
        // TODO: atualizar bancada existente
        return NoContent();
    }
}
