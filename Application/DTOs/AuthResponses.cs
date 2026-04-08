namespace Despacho.API.Application.DTOs;

public sealed record LoginResponse(string Token, DateTime ExpiracaoEm);

public sealed record ErrorResponse(string Erro, string Mensagem);
