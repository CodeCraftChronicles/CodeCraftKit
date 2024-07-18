using Core.CoreFeatures.Interfaces.Common;
using Core.CoreFeatures.Security.Responses.Identity;
using Shared.DTO.Requests.Identity;
using Shared.Wrappers;

namespace Core.CoreFeatures.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}