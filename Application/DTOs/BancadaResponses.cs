namespace Despacho.API.Application.DTOs;

public sealed record BancadaResponse(
    Guid Id,
    string Codigo,
    string Descricao,
    bool Ativo,
    DateTime CriadoEm
);
