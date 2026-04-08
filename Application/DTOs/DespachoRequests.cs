namespace Despacho.API.Application.DTOs;

public sealed record DespachoCreateRequest(string ChaveNfe, Guid BancadaId, DateTime LidoEm);
public sealed record DespachoLoteItemRequest(string ChaveNfe, DateTime LidoEm);
public sealed record DespachoLoteRequest(Guid BancadaId, IReadOnlyList<DespachoLoteItemRequest> Registros);
public sealed record DespachoQueryRequest(Guid? BancadaId = null, DateTime? DataInicio = null, DateTime? DataFim = null, string? ChaveNfe = null, int Pagina = 1, int PorPagina = 50);
public sealed record DeleteDespachoRequest(string Motivo);
