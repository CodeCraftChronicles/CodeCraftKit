using Core.CoreFeatures.Interfaces.Common;
using Core.CoreFeatures.Security.Requests.Identity;

using Shared.Wrappers;

namespace Core.CoreFeatures.Security.Requests.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}