using Core.CoreFeatures.Security.Responses.Identity;

namespace Shared.DTO.Requests.Identity;

public class UpdateUserRolesRequest
{
    public string UserId { get; set; }
    public IList<UserRoleModel> UserRoles { get; set; }
}