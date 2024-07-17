namespace Core.CoreFeatures.Security.Requests.Identity;

public class PermissionRequest
{
    public string RoleId { get; set; }
    public IList<RoleClaimRequest> RoleClaims { get; set; }
}