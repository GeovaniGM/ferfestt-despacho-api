namespace Despacho.API.Application.DTOs;

public sealed record DespachoEventoQueryRequest(Guid? BancadaId = null, string? Tipo = null, DateTime? DataInicio = null, DateTime? DataFim = null);
