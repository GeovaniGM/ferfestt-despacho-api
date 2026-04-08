namespace Despacho.API.Application.DTOs;

public sealed record DespachoResponse(
    Guid Id,
    string ChaveNfe,
    string NumeroNfe,
    Guid BancadaId,
    DateTime LidoEm,
    DateTime RegistradoEm,
    bool Ativo
);

public sealed record DespachoEventoResponse(
    Guid Id,
    string Tipo,
    string ChaveNfe,
    Guid? BancadaId,
    Guid? DespachoId,
    int? Tentativas,
    DateTime? EnviadoEm,
    DateTime? RespondidoEm,
    string? Erro,
    string? Motivo
);

public sealed record DespachoDeleteResponse(
    Guid Id,
    bool Ativo,
    DespachoEventoResponse Evento
);

public sealed record DespachoLoteResultadoItem(
    string ChaveNfe,
    string Status,
    Guid? DespachoId = null,
    string? Erro = null
);

public sealed record DespachoLoteResponse(
    IReadOnlyList<DespachoLoteResultadoItem> Resultados
);

public sealed record PagedResponse<T>(
    int Total,
    int Pagina,
    int PorPagina,
    IReadOnlyList<T> Dados
);
