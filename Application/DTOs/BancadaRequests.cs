namespace Despacho.API.Application.DTOs;

public sealed record BancadaCreateRequest(string Codigo, string Descricao);
public sealed record BancadaUpdateRequest(string? Descricao = null, bool? Ativo = null);
