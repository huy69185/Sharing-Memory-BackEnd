using MemorySharingAPI.DTO.Account;
using MemorySharingAPI.Models;
using System.Security.Claims;

namespace MemorySharingAPI.Services.TokenService;

public interface ITokenService
{
    AuthenticationResponse CreateJwtToken(User user, Role role);
    ClaimsPrincipal? GetPrincipalFromJwtToken(string? token);
}
