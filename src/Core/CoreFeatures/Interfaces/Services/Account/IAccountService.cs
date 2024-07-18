using Core.CoreFeatures.Interfaces.Common;
using Shared.DTO.Requests.Identity;
using Shared.Wrappers;

namespace Core.CoreFeatures.Interfaces.Services.Account
{
    public interface IAccountService: IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}