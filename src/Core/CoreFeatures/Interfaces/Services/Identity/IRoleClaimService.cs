using Core.CoreFeatures.Interfaces.Common;
using Core.CoreFeatures.Security.Requests.Identity;
using Core.CoreFeatures.Security.Responses.Identity;

using Shared.Wrappers;

namespace Core.CoreFeatures.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}