namespace Core.CoreFeatures.Security.Responses.Identity;

public class UserRolesResponse
{
    public List<UserRoleModel> UserRoles { get; set; } = new();
}

public class UserRoleModel
{
    public required string RoleName { get; set; }
    public required string RoleDescription { get; set; }
    public bool Selected { get; set; }
}