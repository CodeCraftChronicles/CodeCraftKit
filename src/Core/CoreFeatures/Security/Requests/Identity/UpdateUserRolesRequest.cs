using Core.CoreFeatures.Security.Responses.Identity;

namespace Core.CoreFeatures.Security.Requests.Identity;

public class UpdateUserRolesRequest
{
    public string UserId { get; set; }
    public IList<UserRoleModel> UserRoles { get; set; }
}